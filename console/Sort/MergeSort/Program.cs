using System;

namespace MergeSort
{
    class Program
    {
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            Array.Copy(arr, left, leftArr, 0, n1);
            Array.Copy(arr, mid + 1, rightArr, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k++] = leftArr[i++];
                }
                else
                {
                    arr[k++] = rightArr[j++];
                }
            }

            while (i < n1) arr[k++] = leftArr[i++];
            while (j < n2) arr[k++] = rightArr[j++];
        }

        public static void Main()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted Array (Merge Sort): " + string.Join(", ", arr));
        }
    }

}
//Pros of Merge Sort:

//Stable sorting(preserves original order of equal elements).

//Guaranteed O(n log n) time complexity, even in worst-case scenarios.

//Efficient for linked lists due to non-contiguous memory usage.
