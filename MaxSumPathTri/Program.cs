using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSumPathTri
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes in an array of numbers
            //@ = string literal
            int[,] list = new int[3, 4]; // multidimensional array, 3 rows and 4 columns. 
            //needs to be refactored in order to display the triangle correctly if I want.
            string input = 
               @"1
               1 2
               1 3 4";
            var rowTri = input.Trim().Split('\n');
            //Console.WriteLine(input);

            //values of rowTri are split to make the triangle
            for (int i = 0; i < rowTri.Length; i++)
            {
                var strArr = rowTri[i].Trim().Split(' ');

                for (int j = 0; j < strArr.Length; j++)
                {
                    int number = Convert.ToInt32(strArr[j]);
                    list[i, j] = number;
                }
                
            }

            //calculation to find the max total
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

