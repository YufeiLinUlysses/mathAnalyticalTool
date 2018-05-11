using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yufei_Lin_IA_Linear_Regression
{
    class Ford_Fulkerson
    {
        public string MaxFlow(int[,] capacity, int source, int sink)
        {
            int[,] residualCapacity = new int[capacity.GetLength(0), capacity.GetLength(1)];
            for (int i = 0; i < capacity.GetLength(0); i++)
            {
                for (int j = 0; j < capacity.GetLength(1); j++)
                {
                    residualCapacity[i, j] = capacity[i, j];
                }
            }
            Dictionary<int, int> parent = new Dictionary<int, int>();
            List<ArrayList> augmentedPaths = new List<ArrayList>();
            //Concerned
            int maxFlow = 0;
            while (BFS(residualCapacity, parent, source, sink))
            {
                ArrayList augmentedPath = new ArrayList();
                //Concerned
                int flow = int.MaxValue;
                int v = sink;
                while (v != source)
                {
                    augmentedPath.Add(v);
                    int u = parent[v];
                    //Concerned
                    if (flow > residualCapacity[u, v])
                    {
                        flow = residualCapacity[u, v];
                    }
                    v = u;
                }
                augmentedPath.Add(source);
                augmentedPath.Reverse();
                augmentedPaths.Add(augmentedPath);
                maxFlow += flow;
                v = sink;
                while (v != source)
                {
                    int u = parent[v];
                    //Concerned
                    residualCapacity[u, v] -= flow;
                    residualCapacity[v, u] += flow;
                    v = u;
                }
            }
            string a = "";
            a = "\n" + "Maximum Capacity: " + maxFlow;
            string b = "";
            b = printAugmentedPaths(augmentedPaths);
            return a+b;
        }
        private string printAugmentedPaths(List<ArrayList> augmentedPaths)
        {
            string alpha = "Augmented paths\n";
            string beta = "";
            foreach(var a in augmentedPaths)
            {
                foreach(var b in a)
                {
                    beta += (b.ToString() + " ");
                }
                beta += "\n";
            }
            return alpha + beta;
        }
        private Boolean BFS(int[,] residualCapacity, Dictionary<int, int> parent,
            int source, int sink)
        {
            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);
            visited.Add(source);
            Boolean foundAugmentedPath = false;
            //see if we can find augmented path from source to sink
            while (queue.Count()!=0)
            {
                int u = queue.Dequeue();
                for (int v = 0; v < residualCapacity.GetLength(0); v++)
                {
                    //explore the vertex only if it is not visited and its residual capacity is
                    //greater than 0
                    if (!visited.Contains(v) && residualCapacity[u,v] > 0)
                    {
                        //add in parent map saying v got explored by u
                        parent[v] = u;
                        //add v to visited
                        visited.Add(v);
                        //add v to queue for BFS
                        queue.Enqueue(v);
                        //if sink is found then augmented path is found
                        if (v == sink)
                        {
                            foundAugmentedPath = true;
                            break;
                        }
                    }
                }
            }
            //returns if augmented path is found from source to sink or not
            return foundAugmentedPath;
        }
    }
}
