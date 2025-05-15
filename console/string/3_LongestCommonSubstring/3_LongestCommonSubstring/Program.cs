using System;

namespace _3_LongestCommonSubstring
{
    class Program
    {
        public static string FindLCS(string str1, string str2) 
        {
            int m = str1.Length; 
            int n = str2.Length; 

            int endIndex = 0;
            int maxLength = 0;

            int[,] dp = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (str1[i-1] == str2[j-1])
                    {
                        dp[i, j] = dp[i-1, j-1] + 1;
                        if (dp[i,j]>maxLength)
                        {
                            maxLength = dp[i, j];
                            endIndex = i;
                        }
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }
            if (maxLength==0)
            {
                return "";
            }
            
            return str1.Substring(endIndex - maxLength, maxLength);
        }
        public static void Main(string[] args)
        {
            string str1 = "asdjklnm";
            string str2 = "zxciopjklnmfgh";
            string lcs = FindLCS(str1, str2);
            Console.WriteLine(lcs);
            Console.ReadKey();
        }
    }
}
