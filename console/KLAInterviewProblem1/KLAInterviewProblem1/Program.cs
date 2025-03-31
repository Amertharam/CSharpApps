using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLAInterviewProblem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int result = calculateTotalTimeTaken(str);
            Console.WriteLine(result);
        }
        public static int calculateTotalTimeTaken(string cells) 
        {
            int N = cells.Length;
            char[] cellsArray= new char[N];
            cellsArray = cells.ToCharArray();
            int totalTime = 0;
            //int totalNumOfplayers = findTotalNumOfPlayers(cells);
        
            for (int i = 0; i < N; i++) 
            {
                if (cellsArray[i] == '0')
                {
                    continue;
                }
                else 
                {
                    if (i >= cellsArray.Length)
                    {
                        totalTime++;
                        continue;
                    }
                    if ((cellsArray[i] == '1') && (cellsArray[i + 1] != '1')) 
                    {
                        totalTime++;
                        char temp = cellsArray[i];
                        cellsArray[i] = cellsArray[i + 1];
                        cellsArray[(i + 1)] = temp;
                    }
                }              
            }
            
            return totalTime;
        }

        //public static int findTotalNumOfPlayers(string cells)
        //{
        //    int totalPlayers = 0;
        //    int i = 0;
        //    while (i < cells.Length) 
        //    {
        //        if (cells[i] == '1')
        //        {
        //            i++;
        //        }
        //    }
        //   return totalPlayers;
        //}
    }
}
