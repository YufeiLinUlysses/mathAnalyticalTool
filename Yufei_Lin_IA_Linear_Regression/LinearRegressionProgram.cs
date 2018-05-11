using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Web;
using System.Diagnostics;

namespace Yufei_Lin_IA_Linear_Regression
{
    public partial class Linear_Regression : Form
    {
        int i = 0;
        int columns1 = 0, columns2 = 1;
        int dLength = 0;
        int count = 0, totalTrials = 0;
        double percentage = 0;
        int a, b;
        
        SortedDictionary<double, double> input = new SortedDictionary<double, double>();
        ArrayList mark1 = new ArrayList();
        ArrayList mark2 = new ArrayList();
        OpenFileDialog fileName = new OpenFileDialog();
        Stopwatch sw = new Stopwatch();

        // Instance of Data Class
        Data d = new Data();

        // Instance of TypeOfRelationship Class
        TypeOfRelationship t = new TypeOfRelationship();

        // Instance of BestFitLineProperties
        BestFitLineProperties currentCategories = new BestFitLineProperties();

        // Initialization of the application
        public Linear_Regression()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Button created to input and read the file
        private void btn_Input_File_Click(object sender, EventArgs e)
        {
            bestFitLine.Text = "Best-Fit Line";
            variance.Text = "Variace of the Best-Fit Line";
            btn_Input_File.Enabled = false;
            totalNum.Text = "";
            label4.Visible = true;
            label4.Text = "Graph Area";
            mark1.Clear();
            mark2.Clear();
            rel_Choices.Items.Clear();
            rel_Choices.Text= "Choices";
            columns1 = 0;
            columns2 = 1;
            d.categories1 = "";
            d.categories2 = "";
            foreach (var series in chartRelationship.Series)
            {
                series.Points.Clear();
            }
            
            input.Clear();
            fileName.InitialDirectory = Application.StartupPath;
            fileName.Filter = "All files (*.*)|*.*|csv files(*.csv)|*.csv";
            fileName.FilterIndex = 2;
            fileName.RestoreDirectory = true;
            if (fileName.ShowDialog() == DialogResult.OK)
            {
                //Try to read the file and show the file path of the input file
                try
                {
                    d.ReadFile(input, fileName.FileName.ToString(),columns1,columns2);
                    txtbx_fileName.Text = d.filePath;
                }

                // If the file can be read but there's other faults, there would be special exception handling within
                // the reading method
                // Here the catch is mainly used to catch the exception when the file is occupied by other applications
                catch
                {
                    MessageBox.Show("Error!"+"The file you import is occupied", "Warning");
                }
                
                input = d.input;
                i = d.count;
                totalNum.Text = (d.length * (d.count-1)).ToString();
            }
            btn_Input_File.Enabled = true;
        }

        /* Button1, is actually named as calculate 
           It is used to calculate the best fit line and exhibit the result.*/
        private void button1_Click(object sender, EventArgs e)
        {
            sw.Restart();
            mark1.Clear();
            mark2.Clear();
            calculate.Enabled = false;
            label4.Text = "Please select a"+"\n"+"  relationship";
            label1.Visible = true;
            rel_Choices.Items.Clear();
            totalTrials = (d.length - 1 + 1) * (d.length - 1) / 2;
            count = 0;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 370;
            dLength = d.length;

            input.Clear();
            d.ReadFile(input, fileName.FileName.ToString(), columns1, columns2);
            input = d.input;

            for (columns1 = 0; columns1 < d.length-1; columns1++)
            {
                for (columns2 = columns1 + 1; columns2 < d.length; columns2++)
                {
                    input = d.FinalID(input);
                    if (t.ProductMomentCorrelation(input))
                    {
                        rel_Choices.Items.Add(d.categories1 + "-" + d.categories2);
                        mark1.Add(columns1);
                        mark2.Add(columns2);
                    }
                    count++;
                    percentage = (370*count / totalTrials);
                    progressBar1.Value = (int)percentage;
                }
            }
            if (mark1.Count==0)
            {
                label4.Text = "     There's no linear " +"\n"+ "relationship in the file.";
            }
            total.Text = mark1.Count.ToString();
            MessageBox.Show("Calculation Finished", "Status");

            label1.Visible = false;
            progressBar1.Visible = false;
            calculate.Enabled = true;
        }
        
        // Draw Line
        private void Draw(SortedDictionary<double,double> input)
        {
            foreach (var corF in input)
            {
                chartRelationship.Series["Relationship"].Points.AddXY(corF.Key, currentCategories.k * corF.Key + currentCategories.b);
                chartRelationship.Series["Data"].Points.AddXY(corF.Key, corF.Value);
            }
        }

        // The application would end with the click on the "End" button
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Application.Exit();
        }

        // Entrance of reading a file 
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Linear_Regression_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void Linear_Regression_SizeChanged(object sender, EventArgs e)
        {
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Picture(*.png)|*.png";
            sfd.Title = "Save The Graph";
            sfd.ShowDialog();
            chartRelationship.BackColor = Color.White;
            if (sfd.FileName != "")
            {
                string temp = sfd.FileName;
                chartRelationship.SaveImage(temp, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
            chartRelationship.BackColor = Color.Transparent;
            button2.Enabled = true;
        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartRelationship_Click(object sender, EventArgs e)
        {

        }

        private void rel_Choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            rel_Choices.Enabled = false;
            label4.Visible = false;
            foreach (var series in chartRelationship.Series)
            {
                series.Points.Clear();
            }
            d.categories1 = "";
            d.categories2 = "";
            input.Clear();
            d.ReadFile(input, fileName.FileName.ToString(), (int)mark1[rel_Choices.SelectedIndex],(int)mark2[rel_Choices.SelectedIndex]);
            input = d.input;
            input = d.FinalID(input);
            i = d.count;
            currentCategories.BestFitLine(input, i);
            variance.Text = Math.Round(currentCategories.variance, 3).ToString();
            if (currentCategories.b >= 0)
            {
                bestFitLine.Text = "y = " + Math.Round(currentCategories.k, 3).ToString() + " x + " + Math.Round(currentCategories.b, 3).ToString();
            }
            else
            {
                bestFitLine.Text = "y = " + Math.Round(currentCategories.k, 3).ToString() + " x - " + Math.Abs(Math.Round(currentCategories.b, 3)).ToString();
            }
            Draw(input);
            chartRelationship.ChartAreas["ChartArea1"].AxisY.Title = d.categories2;
            chartRelationship.ChartAreas["ChartArea1"].AxisX.Title = d.categories1;
            chartRelationship.Titles["Relationship"].Text = "Result: Relationship of " + d.categories1 + " - " + d.categories2;
            rel_Choices.Enabled = true;
        }

    }
}
