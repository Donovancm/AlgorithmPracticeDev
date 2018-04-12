using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_2
{
    class InsertionS
    {
        public static void InsertionSort(int[] data)
        {
            Console.WriteLine("Integer Array Input");
            for (int a = 0; a < data.Length; a++)
            {
                Console.WriteLine(data[a]);
            }
            for (int j = 0; j < data.Length; j++)
            {
                var key = data[j];
                var i = j - 1;
                while (i >= 0 && data[i] >= key)
                {
                    data[i + 1] = data[i];
                    i = i - 1;
                }
                data[i + 1] = key;
            }
            Console.WriteLine("Integer Array Output");
            for (int e = 0; e < data.Length; e++)
            {
                Console.WriteLine(data[e]);
            }
        }
        public static void InsertionPrint()
        {
            int[] data = new int[] { 19, 13, 11, 14, 9, 96, 1, 40, 95, 41, 90 };
            InsertionSort(data);

        }
    }
}