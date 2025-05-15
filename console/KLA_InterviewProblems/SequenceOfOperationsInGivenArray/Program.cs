using System;

namespace SequenceOfOperationsInGivenArray
{
    public class Program
    {
        public static void Do(int[] arr, int n) 
        {
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    int index = findIndexOfMaxVal(arr);
                    arr[index] = arr[index]/2;
                    return;
                }
                int j = i % arr.Length;
                int val = fetch(arr, j);
                int dividedVal = divByTwo(val);
                insertBack(arr, dividedVal, j);
            }
        }

        private static int findIndexOfMaxVal(int[] arr)
        {
            int[] tempArr= (int[])arr.Clone();
            Array.Sort(tempArr);
            int maxValue = tempArr[tempArr.Length - 1];
            int maxIndex = -1;
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k]==maxValue)
                {
                    maxIndex = k; // returns the index of the max Val
                }               
            }
            return maxIndex;
        }

        private static void insertBack(int[] arr, int dividedVal, int i)
        {
            arr[i] = dividedVal;
        }

        private static int divByTwo(int val)
        {
            double res = (double)val / 2;
            return Convert.ToInt32(Math.Round(res));
        }

        private static int fetch(int[] arr, int i)
        {
            return arr[i];
        }

        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 7 };
            int n = 4;
            Do(arr, n);
            var res = arr;
            Console.WriteLine("Processed Array : " + string.Join(",",arr));

            Console.ReadKey();
        }
    }
}
