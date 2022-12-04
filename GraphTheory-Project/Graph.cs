using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory_Project
{
    public class Graph
    {
        private int _V;


        LinkedList<int>[] linkedListArray;
        
        LinkedList<int>[] _adj;
        
        public string DFS_TEXT= "DFS :";
        
        
        public Graph(int v)
        {
            linkedListArray = new LinkedList<int>[v];

            _adj = new LinkedList<int>[v];
            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _V = v;
        }

        /// 

        /// The method takes two nodes for which to add edge.
        /// 

        /// 
        /// 
        /// 
        public void AddEdge(int v, int w)//for BFS
        {
            _adj[v].AddLast(w);

        }





        // Prints BFS traversal from a given source s
        public string BFS(int s)
        {

            // Mark all the vertices as not
            // visited(By default set as false)
            bool[] visited = new bool[_V];
            for (int i = 0; i < _V; i++)
                visited[i] = false;

            // Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as
            // visited and enqueue it
            visited[s] = true;
            queue.AddLast(s);
            string line=" BFS :";
            while (queue.Any())
            {

                // Dequeue a vertex from queue
                // and print it
                s = queue.First();
                Console.Write(s + "->");
                queue.RemoveFirst();
                line += s + "->";
                

                LinkedList<int> list = _adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
            return line;
        }
            
            public void AddEdge(int u, int v, bool blnBiDir = true)
        {
            if (linkedListArray[u] == null)
            {
                linkedListArray[u] = new LinkedList<int>();
                linkedListArray[u].AddFirst(v);
            }
            else
            {
                var last = linkedListArray[u].Last;
                linkedListArray[u].AddAfter(last, v);
            }

            if (blnBiDir)
            {
                if (linkedListArray[v] == null)
                {
                    linkedListArray[v] = new LinkedList<int>();
                    linkedListArray[v].AddFirst(u);
                }
                else
                {
                    var last = linkedListArray[v].Last;
                    linkedListArray[v].AddAfter(last, u);
                }
            }
        }

        internal void DFSHelper(int src, bool[] visited)
        {
            
            DFS_TEXT += src+ "->";
            visited[src] = true;
            Console.Write(src + "->");
            if (linkedListArray[src] != null)
            {
                foreach (var item in linkedListArray[src])
                {
                    if (!visited[item] == true)
                    {
                        DFSHelper(item, visited);
                    }
                }
            }
        }

        internal void DFS()
        {   
            Console.WriteLine("DFS");
            bool[] visited = new bool[linkedListArray.Length + 1];
            DFSHelper(0, visited);

        }



        // Function that returns true if
        // a simple graph exists
        static public bool graphExists(ArrayList a, int n)
        {

            // Keep performing the operations until one
            // of the stopping condition is met
            while (true)
            {

                // Sort the list in non-decreasing order
                a.Sort();
                a.Reverse();

                // Check if all the elements are equal to 0
                if ((int)a[0] == 0)
                    return true;

                // Store the first element in a variable
                // and delete it from the list
                int v = (int)a[0];
                a.Remove(a[0]);

                // Check if enough elements
                // are present in the list
                if (v > a.Count)
                    return false;

                // Subtract first element from
                // next v elements
                for (int i = 0; i < v; i++)
                {
                    a[i] = (int)a[i] - 1;

                    // Check if negative element is
                    // encountered after subtraction
                    if ((int)a[i] < 0)
                        return false;
                }
            }
        }

    }
}
