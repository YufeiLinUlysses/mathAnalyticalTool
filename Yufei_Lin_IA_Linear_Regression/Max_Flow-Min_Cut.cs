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

namespace Yufei_Lin_IA_Linear_Regression
{
    public partial class Max_Flow_Min_Cut : Form
    {
        Ford_Fulkerson f = new Ford_Fulkerson();
        OpenFileDialog fileName = new OpenFileDialog();
        ReadAndWriteCSV r = new ReadAndWriteCSV();
        ReadAndWriteTXT rt = new ReadAndWriteTXT();
        Conversion c = new Conversion();
        DataTable dt = new DataTable();
        Customization cu = new Customization();
        Help h = new Help();

        public int[,] capcaity = new int[100, 100];
        public Max_Flow_Min_Cut()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capcaity = c.DatatableConvertToTwoDArrayIntegersOnly(dt);
            string test = "";
            result.Text = f.MaxFlow(capcaity, 0, 6);
            for(int i = 0; i < capcaity.GetLength(0); i++)
            {
                for(int j = 0; j < capcaity.GetLength(1); j++)
                {
                    test += capcaity[i, j].ToString() + " \n";
                }
            }
            string temp = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "File(*.txt)|*.txt";
            sfd.Title = "Save Data";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                temp = sfd.FileName;
                rt.WriteOutAsTXT(temp, f.MaxFlow(capcaity, 0, 6));
            }
                
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            fileName.InitialDirectory = Application.StartupPath;
            fileName.Filter = "All files (*.*)|*.*|csv files(*.csv)|*.csv";
            fileName.FilterIndex = 2;
            fileName.RestoreDirectory = true;

            if (fileName.ShowDialog() == DialogResult.OK)
            {
                //Try to read the file and show the file path of the input file
                try
                {
                    r.readInToDataTable(dt, fileName.FileName.ToString());
                    result.Text = r.filePath;
                }
                
                // If the file can be read but there's other faults, there would be special exception handling within
                // the reading method
                // Here the catch is mainly used to catch the exception when the file is occupied by other applications
                catch
                {
                    MessageBox.Show("Error!" + "The file you import is occupied", "Warning");
                }

                dt = r.dt;
            }
            button2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            cu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h.tellMeWhichAlgorithm = 1;
            h.Show();
        }

        private void Max_Flow_Min_Cut_Load(object sender, EventArgs e)
        {

        }
    }
}
