using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Yufei_Lin_IA_Linear_Regression
{
    class Conversion
    {
        public int[,] DatatableConvertToTwoDArrayIntegersOnly(DataTable dt)
        {
            int rowIndex1 = dt.Rows.Count;//dsの行数   
            int colIndex1 = dt.Columns.Count;//dsの列数   
            int[,] obj1 = new int[rowIndex1 + 1, colIndex1 + 1];
            for (int i = 0; i < rowIndex1; i++)
            {
                for (int j = 0; j < colIndex1; j++)
                {
                    DataRow dr = dt.Rows[i];
                    obj1[i, j] = int.Parse(dr[j].ToString());
                }
            }
            return obj1;
        }
    }
}
