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
            for (int j = 1; j < data.Length - 1; j++)
            {
                var key = data[j];
                var i = j - 1;
                while (i >= 0 && data[i] > key)
                {
                    data[i + 1] = data[i];
                    i = i - 1;
                }
                data[i + 1] = key;
            }
            Console.WriteLine("Integer Array Output");
            for (int e = 0; e < data.Length - 1; e++)
            {
                Console.WriteLine(data[e]);
            }
        }
        public static void InsertionPrint()
        {
            int[] data = new int[] { 19, 13, 11, 14, 9, 96, 1, 40 };
            InsertionSort(data);

        }
    }
}
//static void MergeSort(int[] array)
//    {
//        int[] result = MergeSort(array, 0, array.Length);
//        Array.Copy(result, array, result.Length);
//    }

//    static int[] MergeSort(int[] array, int start, int end)
//    {
//        // Fase 1 - Split
//        if (end - start < 2)
//            return new int[] { array[start] };

//        int middle = start + ((end - start) / 2);
//        int[] left = MergeSort(array, start, middle);
//        int[] right = MergeSort(array, middle, end);

//        // Fase 2 - Sort and Merge
//        int[] result = new int[left.Length + right.Length];

//        int idxL = 0;
//        int idxR = 0;
//        int i = 0;

//        for (; idxL < left.Length && idxR < right.Length; i++)
//        {
//            if (left[idxL] < right[idxR])
//            {
//                result[i] = left[idxL];
//                idxL++;
//            }
//            else
//            {
//                result[i] = right[idxR];
//                idxR++;
//            }
//        }

//        // copy remaining elements
//        while (idxL < left.Length)
//            result[i++] = left[idxL++];

//        while (idxR < right.Length)
//            result[i++] = right[idxR++];

//        return result;
//    }