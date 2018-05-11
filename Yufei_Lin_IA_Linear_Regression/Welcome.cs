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
    public partial class Welcome : Form
    {
        int i = 0;

        // Constructor of Welcome Page class
        public Welcome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        // After 2 seconds, the welcome page will disappear and the Tips class will show
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            Tips t = new Tips();
            if (i == 2)
            {
                this.Hide();
                
                //Show Tips class
                t.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
