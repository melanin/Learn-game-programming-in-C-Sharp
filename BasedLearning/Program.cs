using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasedLearning
{
    class DataMan
    {
        private int data1;
        private int data2;

        public int Data1
        {
            get
            {
                return data1;
            }
            set
            {
                System.Console.Write("changed: {0}", data1);
                data1 = value;
                System.Console.WriteLine(" >> {0}", data1);
            }
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            DataMan dataMan = new DataMan();
            //System.Console.WriteLine("before: {0}", dataMan.Data1);

            dataMan.Data1 = 10;
            //System.Console.WriteLine("after: {0}", dataMan.Data1);
        }
    }
}
