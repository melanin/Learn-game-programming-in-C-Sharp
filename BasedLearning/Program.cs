using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedLearning
{
    class Program
    {
        enum AMOR_TYPE
        {
            yellow = 10,
            red = 30
        }

        static void Main(string[] args)
        {
            const double PI = 3.1415926535897;

            System.Console.WriteLine("ENUM::AMOR : {0}, {1}", AMOR_TYPE.yellow, AMOR_TYPE.red);
        }
    }
}
