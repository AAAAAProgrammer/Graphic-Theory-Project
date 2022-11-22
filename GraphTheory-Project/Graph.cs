using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory_Project
{
    class Graph
    {
        bool[,] adjMatrix = new bool[10, 10] ;
        int numVertices = 10;


        public Graph()
        {

        }
        // Add edges
        void addEdge(int i, int j)
        {
            adjMatrix[i,j] = true;
            adjMatrix[j,i] = true;
        }


    }
}
