using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasedLearning
{
    class UserType
    {
    }

    class Core
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            System.Console.WriteLine("Hashcode is {0}, {1}", a.GetHashCode(), b.GetHashCode());
        }
    }
}
