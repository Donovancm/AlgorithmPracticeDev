using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_2
{
    class MergeS2
    {
        public static void MergePrint()
        {
            int[] data = new int[] { 19, 13, 11, 14, 6, 99, 44 };
            Console.WriteLine("Integer Array Input");
            for (int a = 0; a < data.Length; a++)
            {
                Console.WriteLine(data[a]);
            }
            RunMerge(data);
            Console.WriteLine("Integer Array Output");
            for (int e = 0; e < data.Length; e++)
            {
                Console.WriteLine(data[e]);
            }
        }
        static void RunMerge(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
        }
        static void MergeSort(int[] arr, int leftBoundary, int rightBoundary)
        {
            if (leftBoundary < rightBoundary)
            {
                int middle = (leftBoundary + rightBoundary) / 2;
                MergeSort(arr, leftBoundary, middle);
                MergeSort(arr, middle + 1, rightBoundary);
                Merge(arr, leftBoundary, middle, rightBoundary);
            }
        }
        static void Merge(int[] arr, int left, int middle, int right)
        {
            int i, j, k;
            int[] arr1 = new int[middle - left + 1];
            int[] arr2 = new int[right - middle];
            for (i = 0, k = left; i < arr1.Length; i++, k++)
            {
                arr1[i] = arr[k];
            }
            for (j = 0, k = middle + 1; j < arr2.Length; j++, k++)
            {
                arr2[j] = arr[k];
            }
            i = j = 0;
            k = left;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i].CompareTo(arr2[j]) <= 0)
                    arr[k++] = arr1[i++];
                else
                    arr[k++] = arr2[j++];
            }
            if (i == arr1.Length)
            {
                arr[k++] = arr2[j++];
            }
            else
            {
                arr[k++] = arr1[i++];
            }
        }
    }
}
