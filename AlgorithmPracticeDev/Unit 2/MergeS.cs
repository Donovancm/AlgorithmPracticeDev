using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeDev.Unit_2
{
    class MergeS
    {
        static void MergeSort(int[] array)
        {
            int[] result = MergeSort(array, 0, array.Length);
            Array.Copy(result, array, result.Length);
        }

        static int[] MergeSort(int[] array, int start, int end)
        {
            // Fase 1 - Split
            if (end - start < 2)
                return new int[] { array[start] };

            int middle = start + ((end - start) / 2);
            int[] left = MergeSort(array, start, middle);
            int[] right = MergeSort(array, middle, end);

            // Fase 2 - Sort and Merge
            int[] result = new int[left.Length + right.Length];

            int idxL = 0;
            int idxR = 0;
            int i = 0;

            for (; idxL < left.Length && idxR < right.Length; i++)
            {
                if (left[idxL] < right[idxR])
                {
                    result[i] = left[idxL];
                    idxL++;
                }
                else
                {
                    result[i] = right[idxR];
                    idxR++;
                }
            }

            // copy remaining elements
            while (idxL < left.Length)
                result[i++] = left[idxL++];

            while (idxR < right.Length)
                result[i++] = right[idxR++];
            return result;
        
        //public static void MergeSort(int[] data, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int mid = (left + right) / 2;
        //        MergeSort(data, left, mid);
        //        MergeSort(data, (mid + 1), right);
        //        Merge(data, left, (mid+ 1), right);
        //    }
        //}

        //public static void Merge(int[] data, int low, int mid, int high)
        //{
        //    int n1 = (mid - low) + 1;
        //    int n2 = (high - mid);
        //    int[] leftArray = new int[n1 + 1];
        //    int[] rightArray = new int[n2 + 1];
        //    int i = 0;
        //    int j = 0;
        //    for ( i = 0; i < n1; i++)
        //    {
        //        leftArray[i] = data[low + i];

        //    }
        //    for ( j = 0; j < n2; j++)
        //    {
        //        rightArray[j] = data[mid + 1 + j];
        //    }
        //    leftArray[n1] = int.MaxValue;
        //    rightArray[n2] = int.MaxValue;
        //     i = 0; //i
        //     j = 0; //j
        //    for (int k = low; k <= high; k++)
        //    {
        //        if (leftArray[i] <= rightArray[j])
        //        {
        //            data[k] = leftArray[j];
        //            i++;
        //        }
        //        else
        //        {
        //            data[k] = rightArray[j];
        //            j++;
        //        }
        //    }
        //Console.WriteLine("Integer Array Output");
        //    for (int e = 0; e < data.Length - 1; e++)
        //    {
        //        Console.WriteLine(data[e]);
        //    }

        }

        public static void MergeSortPrint()
        {
            int[] data = new int[] { 19, 13, 11, 14, 9, 96, 1, 40 };
            Console.WriteLine("Integer Array Input");
            for (int a = 0; a < data.Length; a++)
            {
                Console.WriteLine(data[a]);
            }
            data = MergeSort(data, 0, data.Length);
            Console.WriteLine("Integer Array Output");
            for (int e = 0; e < data.Length; e++)
            {
                Console.WriteLine(data[e]);
            }
        }
    }
}
