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
            TestMod2();
            TestMod2();
            TestMod2();
            TestMod2();
            TestMod2();
        }

        public void TestMod1()
        {
            Random rnd = new Random();
            int result = rnd.Next() % 100;
            if (60 <= result)
            {
                //ActionKick();
            }
        }

        static private Random _rnd = new Random();
        static public void TestMod2()
        {
            int data = _rnd.Next();
            int result = data % 2;
            if (0 == result)
            {
                System.Console.WriteLine("{0}은 2의 배수입니다.", data);
            }
            else
            {
                System.Console.WriteLine("{0}은 2의 배수가 아닙니다.", data);
            }
        }
    }
}
