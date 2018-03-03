using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_6
{
    class FloydWarschall
    {
        public static void FloydWarshallAlgorithm(int[,] graph, int verticesCount)
        {
            int[,] distance = new int[verticesCount, verticesCount];
            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = 0; j < verticesCount; j++)
                {
                    distance[i, j] = graph[i, j];
                }
            }
            for (int k = 0; k < verticesCount; k++)
            {
                for (int i = 0; i < verticesCount; i++)
                {
                    for (int j = 0; j < verticesCount; j++)
                    {
                        if (distance[i,k] + distance[k,j] < distance[i,j])
                        {
                            distance[i, j] = distance[i, k] + distance[k, j];
                        }
                    }
                }
            }
            Print(distance, verticesCount);
        }
        public static void Print(int[,] distance, int verticesCount)
        {
            Console.WriteLine("Shortest distances between every pair of vertices:");
            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = 0; j < verticesCount; j++)
                {
                    if (distance[i,j] == cst)
                    {
                        Console.Write("cst".PadLeft(7));
                    }
                    else
                    {
                        Console.Write(distance[i, j].ToString().PadLeft(7));
                    }
                }
                Console.WriteLine();
            }
        }
        public static int cst = 9999;
        public static void FloydWarschallPrint()
        {
            int[,] graph = {
                         { cst, cst,  -2, cst },
                         { 4, cst,   3, cst },
                         { cst, cst, cst,  2 },
                         { cst, -1, cst, cst }
                           };

            FloydWarshallAlgorithm(graph, 4);
        }
    }
}
