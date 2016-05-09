using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasedLearning
{
    class Core
    {
        static void Main(string[] args)
        {
            int[][] sawToothArray = new int[5][];

            sawToothArray[0] = new int[10];
            sawToothArray[1] = new int[5];
            sawToothArray[2] = new int[8];
            sawToothArray[3] = new int[2];
            sawToothArray[4] = new int[7];

            for (int i = 0; i < sawToothArray.GetLength(0); i++)
            {
                for (int k = 0; k < sawToothArray[i].Length; k++)
                {
                    System.Console.Write("*", sawToothArray[i][k]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
