using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yufei_Lin_IA_Linear_Regression
{
    public partial class Customization : Form
    {
        Linear_Regression l;
        Runge_KuttaMethod r;
        Max_Flow_Min_Cut m;
        LinearProgramming lp;

        public Customization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            l = new Linear_Regression();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            r = new Runge_KuttaMethod();
            r.Show();
        }

        private void Customization_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            m = new Max_Flow_Min_Cut();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lp = new LinearProgramming();
            lp.Show();
        }
    }
}
