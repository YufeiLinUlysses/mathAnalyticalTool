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
    class BestFitLineProperties
    {
        public double k = 0;
        public double b = 0;
        public double variance = 0;
        SortedDictionary<double, double> input = new SortedDictionary<double, double>();

        public void BestFitLine(SortedDictionary<double, double> input1, int i)
        {
            double sumOfX = 0, sumOfY = 0;
            double averageOfX = 0, averageOfY = 0;
            double squareSum = 0;
            double sumOfXYProduct = 0;
            double calculateVariance = 0;
            input = input1;

            foreach (var element in input)
            {
                sumOfX += element.Key;
                squareSum += element.Key * element.Key;
                sumOfY += element.Value;
                sumOfXYProduct += element.Key * element.Value;
            }

            averageOfX = sumOfX / i;
            averageOfY = sumOfY / i;

            k = (i * sumOfXYProduct - sumOfX * sumOfY) / (i * squareSum - sumOfX * sumOfX);
            b = averageOfY - k * averageOfX;

            foreach (var element in input1)
            {
                calculateVariance += (element.Value - k * element.Key - b) * (element.Value - k * element.Key - b);
            }

            variance = calculateVariance / i;
        }
    }
}
