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
            //AndGate();
            //OrGate();
            Complement();
        }

        static void Complement()
        {
            byte age = 38;//00100110
            byte bitVar = (byte)~age;//11011001
            System.Console.WriteLine(age);
            System.Console.WriteLine(bitVar);
        }

        static void OrGate()
        {
            byte age = 128;//10000000
            byte bitVar = 1;//00000001

            byte ret = (byte)(age | bitVar);
            /*******
             10000000
             00000001
            |--------
             10000001
            *///////
            System.Console.WriteLine(ret);
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
