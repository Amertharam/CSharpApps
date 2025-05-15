using System;

namespace QuickSort
{    public class Program
    {
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[i + 1], ref arr[high]);
            return i + 1;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Original Array: " + string.Join(", ", arr));
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Quick Sorted Array: " + string.Join(", ", arr));
        }
    }

}
//Pros of Quick Sort:

//Fast in practice for large datasets (average case: O(n log n)).

//Works well with cache due to in-place sorting.

//Efficient on random data compared to other sorting methods.