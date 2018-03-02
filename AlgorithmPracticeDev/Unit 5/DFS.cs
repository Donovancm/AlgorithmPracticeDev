using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_5
{
    class DFS
    {
        public static void DFSAlgorithm(int startVertex, int Vertices, List<int>[] adjacency)
        {
            bool[] visited = new bool[Vertices];
            Stack<int> stack = new Stack<int>();
            visited[startVertex] = true;
            stack.Push(startVertex);

            while (stack.Count != 0)
            {
                startVertex = stack.Pop();
                Console.WriteLine("next->" + startVertex);
                foreach (int i in adjacency[startVertex])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }

            }
        }
        public static void DFSAlgorithmPrint()
        {
            //Graph graph = new Graph(4);

            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(2, 0);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(3, 3);
            Graph graph = new Graph(7);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 6);


            for (int i = 0; i < graph.Vertices; i++)
            {
                Console.Write(i + ":[");
                string startVertex = "";
                foreach (var k in graph.adjacency[i])
                {
                    startVertex = startVertex + (k + ",");
                }
                startVertex = startVertex.Substring(0, startVertex.Length);
                startVertex = startVertex + "]";
                Console.Write(startVertex);
                Console.WriteLine();

                int startNode = 0;
                Console.WriteLine("BFS traversal starting from vertex : " + startNode);
                DFSAlgorithm(startNode, 7, graph.adjacency);
            }
        }
    }

}
