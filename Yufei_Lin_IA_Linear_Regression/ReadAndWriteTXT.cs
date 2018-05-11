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
    class ReadAndWriteTXT
    {
        /* Read in txt
         * private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            string a = "";
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Document|*.txt", Multiselect = false, ValidateNames = true })
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            a = await sr.ReadToEndAsync();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            test = a.Split(Environment.NewLine.ToCharArray());
            
            button2.Enabled = true;
        }
         * */

        public void WriteOutAsTXT(string path,string text)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(text);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
    }
}
