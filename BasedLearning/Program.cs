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
        public static void PrintText()
        {
            System.Console.WriteLine("Core::PrintText()");
        }

        public static int Foo(int __x)
        {
            return __x * __x;
        }

        static void Main(string[] args)
        {
            PrintText();//static인 Main에서 호출하므로 PrintText도 static이여야 한다

            int r = Foo(2);
            System.Console.WriteLine(r);
        }
    }
}
