using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_1
{
    class BinaryS
    {
        public static void BinaryPrint()
        {
            int[] data = new int[] { 10, 11, 12, 14, 19, 25, 35, 40 };
            BinaryS.BinarySearch(data, 0, 7, 12);
            int result = BinaryS.BinarySearchIterative(data, 40);
            if (result == -1)
            {
                Console.WriteLine("Number not found");
            }
            else
            {
                Console.WriteLine("Number found at "+ "index " + result);
            }
        }
        public static void BinarySearch(int[] data, int low, int high, int target)
        {
            int lows = low;
            int highs = high;
            while (lows <= highs)
            {
                int middle = (lows + highs) / 2;
                if (target < data[middle])
                {
                    highs = middle - 1;
                    BinarySearch(data, lows, highs, target);
                }
                else if (target > data[middle])
                {
                    lows = middle + 1;
                    BinarySearch(data, lows, highs, target);
                }
                else
                {
                    Console.WriteLine("Index: " + (middle));
                }
                break;
            }
        }
        public static int BinarySearchIterative(int[] data, int target)
        {
            int start = 0;
            int end = data.Length - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (target == data[middle])
                {
                    return middle;
                }
                else if (target < data[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
            }
            return -1;
        }
    }
}
