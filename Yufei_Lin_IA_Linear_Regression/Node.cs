using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yufei_Lin_IA_Linear_Regression
{
    class Node
    {
        Dictionary<Node, Edge> adjacent = new Dictionary<Node, Edge>();

        public Edge getEdge(Node n)
        {
            return adjacent[n];
        }
    }

}
