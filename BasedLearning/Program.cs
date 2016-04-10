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
            float PI = 3.141593F;
            int PI2 = (int)PI;

            //System.Console.WriteLine("PI = " + PI);
            //System.Console.WriteLine("PI2 = " + PI2);

            int PI3 = 5;

            PI = PI3;
            System.Console.WriteLine("PI = {0}", PI);

            //PI3 = PI;//에러 난다
            //System.Console.WriteLine("PI3 = {0}", PI3);
        }
    }
}
