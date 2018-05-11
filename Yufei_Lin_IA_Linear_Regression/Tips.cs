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
    public partial class Tips : Form
    {
        Customization c;
        Linear_Regression l;

        public Tips()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // After click the "close" button, the main application will show up
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            c = new Customization();
            // Show the main application
            c.Show();
        }
        private void Tips_FormClosing(object sender, EventArgs e)
        {
        }
        private void Tips_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
