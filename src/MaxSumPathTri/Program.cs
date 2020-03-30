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
            int[,] triangle = new int[3, 4]; // multidimensional array, 3 rows and 4 columns. 
            string input = 
               @"1
               1 2
               1 3 4";
            var rowTri = input.Trim().Split('\n');

            for (int i = 0; i < rowTri.Length; i++)
            {
                var rowElements = rowTri[i].Trim().Split(' ');

                for (int j = 0; j < rowElements.Length; j++)
                {
                    int number = Convert.ToInt32(rowElements[j]);
                    triangle[i, j] = number;
                }
            }

            //calculation to find the max total
            for (int i = 1; i >= 0; i--)
            {
                for (int j = 0; j < 3; j++)
                {
                    //extraction is the technique
                    var firstNumber = triangle[i, j] + triangle[i + 1, j];
                    var secondNumber = triangle[i, j] + triangle[i + 1, j + 1];
                    triangle[i, j] = Math.Max(firstNumber, secondNumber);
                }
            }
            Console.WriteLine(string.Format("Maximum total: {0}", triangle[0, 0]));            
        }
    }
}

