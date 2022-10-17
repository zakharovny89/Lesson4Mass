using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Mass
{
    internal class Counter
    {
        internal static void NumberOfPositive(int[,] Massive, int row, int column)
        {
            int numberOfPositive = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (Massive[i, j] >0)
                    {
                        numberOfPositive++;
                    }
                }
            }
            Console.WriteLine(numberOfPositive);
        }
        internal static void NumberOfNegative(int[,] Massive, int row, int column)
        {
            int numberOfNegative = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (Massive[i, j] < 0)
                    {
                        numberOfNegative++;
                    }
                }
            }

            Console.WriteLine(numberOfNegative);
        }


    }
}
