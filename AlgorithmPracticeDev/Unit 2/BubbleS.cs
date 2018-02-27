using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_2
{
    class BubbleS
    {
        public static void BubbleSort(int[] data)
        {
            Console.WriteLine("Integer Array Input");
            for (int a = 0; a < data.Length; a++)
            {
                Console.WriteLine(data[a]);
            }
            for (int i = data.Length - 1; i > 0; i--)
            {
                int temp;
                for (int j = 0; j < (i-1); j++)
                {
                   
                    if (data[j] > data[j+1])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Integer Array Output");
            for (int e = 0; e < data.Length - 1; e++)
            {
                Console.WriteLine(data[e]);
            }
        }
        public static void BubblePrint()
        {
            int[] data = new int[] { 19, 13, 11, 14, 9, 96, 1, 40 };
            BubbleSort(data);

        }
    }
}
