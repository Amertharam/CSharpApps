using System;

namespace Sort
{
    public class Program
    {
        public static void BubbleSort(int[] arr) 
        {           
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1]) //swap if adjacent is greater
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = { 5, 6, 7, 8, 7, 3, 2, 1 };
            Console.WriteLine("org arr : " + string.Join(",",arr));
            BubbleSort(arr);
            Console.WriteLine("sorted arr : " + string.Join(",",arr));
            Console.ReadKey();
        }
    }
}
