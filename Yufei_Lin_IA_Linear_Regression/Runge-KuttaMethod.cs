using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Yufei_Lin_IA_Linear_Regression
{
    public partial class Runge_KuttaMethod : Form
    {
        int iS, iA, j;
        int i;
        SortedDictionary<double, double> input1 = new SortedDictionary<double, double>();
        SortedDictionary<double, double> input2 = new SortedDictionary<double, double>();

        public Runge_KuttaMethod()
        {
            InitializeComponent();
            this.AutoSize = true;
        }

        private void DrawY()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var corF in input1)
            {
                chart1.Series["r"].Points.AddXY(corF.Key, corF.Value);
                chart1.Series["Data Point (t-r)"].Points.AddXY(corF.Key, corF.Value);
            }
        }

        private void DrawY2()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var corF in input2)
            {
                chart1.Series["r'"].Points.AddXY(corF.Key, corF.Value);
                chart1.Series["Data Point (t-r')"].Points.AddXY(corF.Key, corF.Value);
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Picture(*.png)|*.png";
            sfd.Title = "Save The Graph";
            sfd.ShowDialog();
            chart1.BackColor = Color.White;
            if (sfd.FileName != "")
            {
                string temp = sfd.FileName;
                chart1.SaveImage(temp, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
            chart1.BackColor = Color.Transparent;
        }

        private double vSqr(double t)
        {
            double k = 0;
            k = -7500 / (2400 - 2.55 * t);
            double b = 1700;
            return Math.Pow((k * t + b), 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisY.IsStartedFromZero = false;
            DrawY();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.IsStartedFromZero = false;
            DrawY2();
        }

        private double ySqr(double vectorU)
        {
            return Math.Pow(vectorU, 2);
        }

        private void Runge_KuttaMethod_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double w = Math.Pow(10, -11) * 6.673 * Math.Pow(10, 22) * 7.3477;
            double xSquared = 0, ySquared = 0;
            double v = 0;
            double ro0 = 0, ro = 0;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for(double i = -1794.5; i <= 1794.5; i += 0.1)
            {
                xSquared = (i-42.5) * (i-42.5);
                ySquared = 1793.997*1793.997 - ((1793.997*1793.997) / (1794.5*1794.5)) * i * i;
                ro0 = Math.Pow(Math.Pow(1793.997, 4) * Math.Pow(1794.5, 2), 3 / 2) / Math.Pow(1794.5 * 1793.997, 4);
                ro = Math.Pow(Math.Pow(1794.5,4)*ySquared+Math.Pow(1793.997, 4) * Math.Pow(i, 2), 3 / 2) / Math.Pow(1794.5 * 1793.997, 4);
                v = Math.Sqrt(((ySquared + xSquared) * (1700 * 1700) * ro) / (ro0 * (1794.5 - 42.5) * (1794.5 - 42.5)));
                chart1.Series["Speed of Satellite"].Points.AddXY(i, v);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double w = Math.Pow(10, -11) * 6.673 * Math.Pow(10, 22) * 7.3477;
                double xSquared = 0, ySquared = 0;
                double y = 0;
                int count = 0;
                double percentage = 0;
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 419;
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                for (double i = -1794.5; i <= 1794.5; i += 0.1)
                {
                    xSquared = i * i;
                    ySquared = 1793.997 * 1793.997 - ((1793.997 * 1793.997) / (1794.5 * 1794.5)) * i * i;
                    y = Math.Sqrt(ySquared);
                    chart1.Series["Ellipse Orbit1"].Points.AddXY(i, y);
                    chart1.Series["Ellipse Orbit1"].Color = Color.Black;
                    chart1.Series["Ellipse Orbit2"].Points.AddXY(i, -y);
                    chart1.Series["Ellipse Orbit2"].Color = Color.Black;
                    count++;
                    percentage = (419 * count / 35890);
                    progressBar1.Value = (int)percentage;
                }
            }
            catch
            {
                MessageBox.Show("Exception");
            }
            
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            input1.Clear();
            input2.Clear();
            string temp = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "File(*.txt)|*.txt";
            sfd.Title = "Save Data";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                temp = sfd.FileName;
                FileStream fs = new FileStream(temp, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                double y = 0, z = 0;
                double t = 0;
                iS = int.Parse(intervalSize.Text);
                iA = int.Parse(intervalAmount.Text);
                y = 15000+1737000;
                z = 0;
                double w = Math.Pow(10, -11) * 6.673 * Math.Pow(10, 22) * 7.3477;
                double dt = 0;
                dt = (iS - t) / iA;
                double k11,k21,k12,k22,k13,k23,k14,k24;
                for (t = 0; t <= iS; t += dt) 
                {
                    k11 = z;
                    k21 = w / ySqr(y) - vSqr(t) / y;
                    k12 = z + (dt / 2) * k21;
                    k22 = w / ySqr(y + (dt / 2) * k11) - vSqr(dt / 2) / (y + (dt / 2) * k21);
                    k13 = z + (dt / 2) * k22;
                    k23 = w / ySqr(y + (dt / 2) * k12) - vSqr(dt / 2) / (y + (dt / 2) * k22);
                    k14 = z + (dt / 2) * k23;
                    k24 = w / ySqr(y + (dt / 2) * k13) - vSqr(dt / 2) / (y + (dt / 2) * k23);
                    y = y - (dt / 6) * (k11 + 2 * k12 + 2 * k13 + k14);
                    z = z + (dt / 6) * (k21 + 2 * k22 + 2 * k23 + k24);
                    sw.Write(Math.Round(y, 4).ToString() + " m" + "\t" + Math.Round(z, 4).ToString() + "m/s "+"\t");
                    if (y <= 3000 + 1738000 && z >= 57 && y >= 1738000)
                    {
                        answer.Text = Math.Round(t,3).ToString()+"s";
                        MessageBox.Show("Finished", "Result");
                        break;
                    }
                    input1.Add(t, y);
                    input2.Add(t, z);
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }
    }
}
