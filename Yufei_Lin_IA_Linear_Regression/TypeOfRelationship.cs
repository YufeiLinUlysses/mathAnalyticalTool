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
    class TypeOfRelationship
    {
        double r = 0;
        public Boolean ProductMomentCorrelation(SortedDictionary<double, double> input)
        {
            double sumOfXY = 0, sumOfX = 0, sumOfY = 0, sumOfXSquared = 0, sumOfYSquared = 0;
            double squareRt1 = 0;
            double squareRt2 = 0;
            double i = 0;
            i = input.Count;
            foreach (var element in input)
            {
                sumOfX += element.Key;
                sumOfXSquared += element.Key * element.Key;
                sumOfY += element.Value;
                sumOfYSquared += element.Value * element.Value;
                sumOfXY += element.Key * element.Value;
            }
            squareRt1 = Math.Sqrt(i * sumOfXSquared - sumOfX * sumOfX);
            squareRt2 = Math.Sqrt(i * sumOfYSquared - sumOfY * sumOfY);
            r = 1.0*(i * sumOfXY - sumOfX * sumOfY) / (squareRt1 * squareRt2);
            if (Math.Abs(Math.Round(r,1)) >= 0.7 && Math.Abs(Math.Round(r, 1)) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
