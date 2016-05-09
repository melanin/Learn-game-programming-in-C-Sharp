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
            int[,] twoMap = new int[5, 10];

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    System.Console.Write(twoMap[y, x]);
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();

            int[,] twoMap2 = new int[5, 10]
                {
                    { 0,0,0,0,0,0,0,0,0,0 },
                    { 0,1,1,1,1,1,1,1,1,0 },
                    { 0,1,1,1,1,1,1,1,1,0 },
                    { 0,1,1,1,1,1,1,1,1,0 },
                    { 0,0,0,0,0,0,0,0,0,0 }
                };
            for (int y = 0; y < twoMap2.GetLength(0); y++)
            {
                for (int x = 0; x < twoMap2.GetLength(1); x++)
                {
                    System.Console.Write(twoMap2[y, x]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
