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
            AndGate();
        }

        static void AndGate()
        {
            byte age = 4;//00000100
            byte bitVar = 1;//00000001
            bitVar <<= 2;//00000001 -> 00000100

            System.Console.WriteLine(age & bitVar);
            /*******
             00000100
             00000100
            &--------
             00000100
            *///////
            System.Console.WriteLine(bitVar);

            bitVar = 1;//00000001
            bitVar <<= 3;//00000001 -> 00001000

            System.Console.WriteLine(age & bitVar);
            /*******
             00000100
             00001000
            &--------
             00000000
            *///////
            System.Console.WriteLine(bitVar);
        }
    }
}
