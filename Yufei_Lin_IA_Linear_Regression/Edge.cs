using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yufei_Lin_IA_Linear_Regression
{
    class Edge
    {
        public int capacity = 0;
        public int flow = 0;

        public Edge()
        {
            capacity = 0;
            flow = 0;
        }
        public int getCapacity()
        {
            return capacity;
        }
        public int getFlow()
        {
            return flow;
        }

    }
}
