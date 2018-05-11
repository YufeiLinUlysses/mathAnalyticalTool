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

namespace Yufei_Lin_IA_Linear_Regression
{
    class Data
    {
        public String categories1 = "";
        public String categories2 = "";
        public int count;
        public SortedDictionary<double, double> input = new SortedDictionary<double, double>();
        public ArrayList y = new ArrayList();
        double upperQuartile = 0, lowerQuartile = 0, median = 0;
        double iqr1 = 0, iqr2 = 0;
        public int length = 0;
        public string filePath = "";

        public void ReadFile(SortedDictionary<double, double> input1, String Path, int i, int j)
        {
            // Set each variable that needs further calculation into its initial state
            count = 0;
            input = input1;
            categories1 = "";
            categories2 = "";
            y.Clear();

           // Import the file from the computer
            var reader = new StreamReader(File.OpenRead(@Path));
            filePath = Path;

            // Read file
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                length = values.Length;

                // Try the following lines
                try
                {
                    // Add elements into the SortedDictionary input for futher process
                    input.Add(double.Parse(values[i]), double.Parse(values[j]));

                    // Add the y value of each function into the ArrayList y for further process
                    y.Add(double.Parse(values[j]));
                }

                // If the above lines are invalid, do the followings
                catch
                {
                    try
                    {
                        if (categories1 == "" && categories2 == "")
                        {
                            categories1 = values[i];
                            categories2 = values[j];
                        }
                        else if (input.ContainsKey(double.Parse(values[0])))
                        {
                            double a = double.Parse(values[i]);
                            double b = double.Parse(values[j]);
                            while (input.ContainsKey(a))
                            {
                                a += 0.0001;
                            }
                            input.Add(a, b);
                            y.Add(b);
                        }
                    }
                    catch
                    {
                        String output = "";
                        output += (count+1).ToString();
                        MessageBox.Show("Error!"+"\n"+"Please check line: "+output+" in your file under categories: "+categories1+" & "+categories2+".", "Warning");
                        Application.Exit();
                        break;
                    }
                }
                count++;
            }
        }

        private void Calculation()
        {
            if (y.Count % 2 == 1)
            {
                median = (double)y[y.Count / 2 + 1];
            }
            else
            {
                median = ((double)y[y.Count / 2] + (double)y[y.Count / 2 - 1]) / 2;
            }

            upperQuartile = (double)y[3 * (y.Count - 1) / 4 + 1];
            lowerQuartile = (double)y[(y.Count - 1) / 4 + 1];
            iqr1 = upperQuartile - median;
            iqr2 = median - lowerQuartile;
        }

        public Boolean Find(double yCor)
        {
            if ((yCor - upperQuartile) > 1.5 * iqr1 || (lowerQuartile - yCor) > 1.5 * iqr2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public SortedDictionary<double, double> FinalID(SortedDictionary<double, double> input1)
        {
            Calculation();
            for(int i = 0; i < y.Count; i++)
            {
                if (!Find((double)(y[i])))
                {
                    foreach(double value in new List<double>(input1.Values))
                    {
                        if (value == (double)y[i])
                        {
                            input1.Remove(FindKey(input1,value));
                        }
                    }
                }
            }
            count = input1.Count;
            return input1;
        }

        private double FindKey(SortedDictionary<double, double> input1, double value)
        {
            double b = 0;
            foreach(var element in input1)
            {
                double a = element.Value;
                
                if (a == value)
                {
                    b = element.Key;
                    break;
                }
            }
            return b;
        }
    }
}
