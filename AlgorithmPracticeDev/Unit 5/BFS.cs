using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_5
{
    class BFS
    {
        public static void BFSAlgorithm(int startVertex, int Vertices, List<int>[] adjacency)
        {
            bool[] visited = new bool[Vertices];
            Queue<int> queue = new Queue<int>();
            visited[startVertex] = true;
            queue.Enqueue(startVertex);
            while (queue.Count != 0)
            {
                startVertex = queue.Dequeue();
                Console.WriteLine("next ->" + startVertex);
                foreach (int next in adjacency[startVertex])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }
        public static void BFSAlgorithmPrint()
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
            graph.AddEdge(0, 4);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 5);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 6);


            for (int i = 0; i < graph.Vertices; i++)
            {
                Console.Write(i+":[");
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
                Console.WriteLine("BFS traversal starting from vertex : "+startNode);
                BFSAlgorithm(startNode, 7, graph.adjacency);
            }
        }
    }
    public class Graph
    {
        public int Vertices;
        public List<int>[] adjacency;

        public Graph(int vertex)
        {
            Vertices = vertex;
            adjacency = new List<int>[vertex];
            for (int i = 0; i < vertex ; i++)
            {
                adjacency[i] = new List<int>();
            }
        }
        public void AddEdge(int vertex, int weighted)
        {
            adjacency[vertex].Add(weighted);
        }
    }
}
