using System;
using System.Collections.Generic;
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
    public partial class LinearProgramming : Form
    {
        ReadAndWriteTXT rt = new ReadAndWriteTXT();
        OpenFileDialog fileName = new OpenFileDialog();
        GetNumbers gn = new GetNumbers();
        String[] test = new String[1000];
        double[,] coefficients = new double[100, 100];
        double[,] coefficientsOnLHS = new double[100, 100];
        double[] coefficientsOnRHS = new double[100];
        public LinearProgramming()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            double[,] results = new double[100, 100];
            results = gn.assemble(test);
            var s = new Simplex(
            gn.getmainFunc(results),
            gn.getCoefOnLHS(results),
            gn.getCoefOnRHS(results)
            );
            var answer = s.maximize();
            string outcome = "";
            outcome += answer.Item1.ToString() + "\n";
            outcome += string.Join(", ", answer.Item2);
            textBox1.Text = outcome;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }

        private void LinearProgramming_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            string a = "";
            string x = "";
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Document|*.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            a = await sr.ReadToEndAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            test = a.Split(Environment.NewLine.ToCharArray());
            coefficients = gn.assemble(test);
            for (int i = 0; i < gn.numberofCoefficient - 1; i++)
            {
                for (int j = 0; j < gn.numberofConstraints; j++)
                {
                    coefficientsOnLHS[i, j] = coefficients[i, j];
                }
            }
            for (int k = 0; k < gn.numberofConstraints; k++)
            {
                coefficientsOnRHS[k] = coefficients[k, gn.numberofCoefficient - 1];
            }
            button2.Enabled = true;
            button1.Enabled = true;
        }
    }
}
