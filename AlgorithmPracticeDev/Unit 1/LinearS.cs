using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_1
{
    class LinearS
    {
        public static void LinearPrint()
        {
            Console.WriteLine("Please enter some integers, seperated by spaces");
            string input = Console.ReadLine();
            string[] integers = input.Split(' ');
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine("i={0} integers[i]={1}", i, integers[i]);
            }

            int[] data = new int[integers.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = int.Parse(integers[i]);
            }

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("i={0} data[i]={1}", i, data[i]);
            }

            while (true)
            {
                Console.WriteLine("Please enter a number you want to find:");
                input = Console.ReadLine();
                if (input.Length == 0)
                    break;
                int searchItem = int.Parse(input);
                Console.WriteLine("Please enter a position to start searching from (0 for beginning): ");
                input = Console.ReadLine();
                int searchPos = int.Parse(input);
                int foundPos = LinearSearch(data, searchItem, searchPos);
                if (foundPos < 0)
                    Console.WriteLine("Item {0} not found", searchItem);
                else
                    Console.WriteLine("Item {0} found at index {1}", searchItem, foundPos);

            }
        }
        public static int LinearSearch(int[] data, int value, int start)
        {
            int number = data.Length;
            if (start < 0)
                return -1;
            for (int i = start; i < number; i++)
                if (data[i] == value)
                    return i;
            return -1;
        }
    }
}
