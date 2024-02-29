using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.src
{
    internal static class Sort
    {
        public static void SelectionSort(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                int min = j;

                for (int i = j + 1; i < array.Length; i++)
                    if (array[i] < array[min])
                        min = i;

                if (array[j] != array[min])
                    Helpers.SwapNumbers(j, min, array);
            }
        }

        public static void QuickSort(int[] array, int start, int end)
        {
            int pivot = array[start / 2 + end / 2];
            int i = start;
            int j = end; // -1 depending on signature requirement

            while (i <= j) { 
                while (array[i] < pivot)
                    i++;

                while (array[j] > pivot)
                    j--;

                if (i <= j)
                {
                    Helpers.SwapNumbers(i, j, array);
                    i++;
                    j--;
                }
            }

            if (i < end)
                QuickSort(array, i, end);
            
            if (start < j)
                QuickSort(array, start, j);
        }

        public static void BubbleSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1])
                        Helpers.SwapNumbers(j, j + 1, array);
        }

        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 & array[j - 1] > array[j])
                {
                    Helpers.SwapNumbers(j, j - 1, array);
                    j--;
                }
            }
        }
    }
}
