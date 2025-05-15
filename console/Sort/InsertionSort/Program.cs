using System;

namespace InsertionSort
{
    public class Program
    {
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Main()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            InsertionSort(arr);
            Console.WriteLine("Sorted Array (Insertion Sort): " + string.Join(", ", arr));
        }
    }

}

//Pros of Insertion Sort:

//Simple and easy to implement.

//Efficient for small datasets or nearly sorted arrays.

//In-place sorting, requiring no additional memory.