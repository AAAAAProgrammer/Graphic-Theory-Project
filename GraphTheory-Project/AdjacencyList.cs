using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory_Project
{
    class AdjacencyList
    {

        public LinkedList<Tuple<int, int>>[] adjacencyList;

        // Constructor - creates an empty Adjacency List
        public AdjacencyList(int vertices)
        {
            adjacencyList = new LinkedList<Tuple<int, int>>[vertices];

            for (int i = 0; i < adjacencyList.Length; ++i)
            {
                adjacencyList[i] = new LinkedList<Tuple<int, int>>();
            }
        }

        // Appends a new Edge to the linked list
        public void addEdgeAtEnd(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddLast(new Tuple<int, int>(endVertex, weight));
        }

        // Adds a new Edge to the linked list from the front
        public void addEdgeAtBegin(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddFirst(new Tuple<int, int>(endVertex, weight));
        }

        // Returns number of vertices
        // Does not change for an object
        public int getNumberOfVertices()
        {
            return adjacencyList.Length;
        }

        // Returns a copy of the Linked List of outward edges from a vertex
        public LinkedList<Tuple<int, int>> this[int index]
        {
            get
            {
                LinkedList<Tuple<int, int>> edgeList
                               = new LinkedList<Tuple<int, int>>(adjacencyList[index]);

                return edgeList;
            }
        }

        // Prints the Adjacency List
        public void printAdjacencyList()
        {
            int i = 0;

            foreach (LinkedList<Tuple<int, int>> list in adjacencyList)
            {
                Console.Write("adjacencyList[" + i + "] -> ");

                foreach (Tuple<int, int> edge in list)
                {
                    Console.Write(edge.Item1 + "----->" );
                }

                ++i;
                Console.WriteLine();
            }
        }
        // Removes the first occurence of an edge and returns true
        // if there was any change in the collection, else false
        public bool removeEdge(int startVertex, int endVertex, int weight)
        {
            Tuple<int, int> edge = new Tuple<int, int>(endVertex, weight);

            return adjacencyList[startVertex].Remove(edge);
        }
    }
}
