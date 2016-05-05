using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasedLearning
{
    class Core
    {
        public delegate int Print(string __message);

        public static int SpeakA(string __message)
        {
            System.Console.Write("Aaaaaaaaaaaaa ");
            System.Console.WriteLine(__message);
            return 0;
        }
        public static int SpeakB(string __message)
        {
            System.Console.Write("Bbbbbbbbbbbbb ");
            System.Console.WriteLine(__message);
            return 1;
        }

        static void Main(string[] args)
        {
            Print a = new Print(SpeakA);
            Print b = new Print(SpeakB);
            Print c;

            Random rnd = new Random();
            if (rnd.Next(100) > 50)
            {
                c = a;
            }
            else
            {
                c = b;
            }

            c("Hi!!");
        }
    }
}
