using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSumPathTri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] list = new int[3, 4];
            string input = @"1
               1 2
               1 3 4";
            var charArray = input.Split('\n');

            for (int i = 0; i < charArray.Length; i++)
            {
                var numArr = charArray[i].Trim().Split(' ');

                for (int j = 0; j < numArr.Length; j++)
                {
                    int number = Convert.ToInt32(numArr[j]);
                    list[i, j] = number;
                }
            }

            for (int i = 1; i >= 0; i--)
            {
                for (int j = 0; j < 3; j++)
                {
                    list[i, j] = Math.Max(list[i, j] + list[i + 1, j], list[i, j] + list[i + 1, j + 1]);
                }
            }
            Console.WriteLine(string.Format("Maximum total: {0}", list[0, 0]));
        }
    }
}
