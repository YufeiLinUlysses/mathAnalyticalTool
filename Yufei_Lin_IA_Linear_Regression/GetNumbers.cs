using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yufei_Lin_IA_Linear_Regression
{
    class GetNumbers
    {
        public int numberofCoefficient = 0, numberofConstraints = 0;
        public bool isNumber(char c)
        {
            double result = -1.00;
            try
            {
                result = double.Parse(c.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string[] splittedIntoSmallSections(string a)
        {
            string[] holder = new string[1000];
            string carrier = "";
            carrier = a.Replace("-", "!-");
            holder = carrier.Split(new char[] { '+', '!', '=', '<', '>' });
            holder = holder.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            return holder;
        }

        public double getCoefficient(string a)
        {
            double ans = 0;
            if (a[0] != '-' && isNumber(a[0]))
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (!isNumber(a[i]))
                    {
                        ans = double.Parse(a.Substring(0, i));
                        break;
                    }
                }
            }
            else if (a[0] == '-' && isNumber(a[1]))
            {
                for (int i = 1; i < a.Length; i++)
                {
                    if (!isNumber(a[i]))
                    {
                        ans = 0 - double.Parse(a.Substring(1, i - 1));
                        break;
                    }
                }
            }
            else if (a[0] != '-' && !isNumber(a[0]))
            {
                ans = 1.00;
            }
            else if (a[0] == '-' && !isNumber(a[1]))
            {
                ans = -1.00;
            }
            return ans;
        }

        public double[] getAllCoefficientForOneString(string a)
        {
            double[] coefs = new double[100];
            string temp = "";
            string[] tempo = new string[1000];
            int count = 0;
            temp = a.Replace(" ", "");
            tempo = splittedIntoSmallSections(temp);
            for (int i = 0; i < tempo.Length; i++)
            {
                if (i == tempo.Length - 1)
                {
                    tempo[i] += "x";
                }
                coefs[count] = getCoefficient(tempo[i]);
                count++;
            }
            numberofCoefficient = count;
            return coefs;
        }

        public double[,] assemble(string[] a)
        {
            double[,] coefsAns = new double[100, 100];
            double[] temp = new double[100];
            int count = 0;
            string[] ans = new string[1000];
            foreach (var c in a)
            {
                Array.Clear(temp, 0, temp.Length);
                temp = getAllCoefficientForOneString(c);
                for (int i = 0; i < temp.Length; i++)
                {
                    coefsAns[count, i] = temp[i];
                }
                count++;
            }
            numberofConstraints = count;
            return coefsAns;
        }

        public double[] getmainFunc(double[,] a)
        {
            double[] mainFunc = new double[100];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                mainFunc[i] = a[0, i];
            }
            return mainFunc;
        }

        public double[,] getCoefOnLHS(double[,] a)
        {
            double[,] coefOnLHS = new double[100, 100];
            for (int i = 0; i < numberofConstraints - 1; i++)
            {
                for (int j = 0; j < numberofCoefficient - 1; j++)
                {
                    coefOnLHS[i, j] = a[i + 1, j];
                }
            }
            return coefOnLHS;
        }

        public double[] getCoefOnRHS(double[,] a)
        {
            double[] coefOnRHS = new double[100];
            for (int i = 0; i < a.GetLength(1) - 1; i++)
            {
                coefOnRHS[i] = a[i + 1, numberofCoefficient - 1];
            }
            return coefOnRHS;
        }
    }
}
