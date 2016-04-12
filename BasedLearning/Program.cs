using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 100;
jmp_here:

            if(var1 == 100)
            {
                System.Console.WriteLine("a는 100이요.");
                var1 = 200;
                goto jmp_here;
            }
            else
            {
                System.Console.WriteLine("실행 안됨");
                System.Console.WriteLine("a는 100이 아니요");
            }
        }
    }
}
