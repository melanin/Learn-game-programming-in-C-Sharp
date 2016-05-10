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
                data1 = value;
            }
        }

        public int Data2
        {
            get
            {
                return data2;
            }
            //set
            //{
            //    data2 = value;
            //}
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            DataMan dataMan = new DataMan();
            System.Console.WriteLine("before: {0}", dataMan.Data1);

            dataMan.Data1 = 10;
            System.Console.WriteLine("after: {0}", dataMan.Data1);

            System.Console.WriteLine("DATA2: {0}", dataMan.Data2);
            //dataMan.Data2 = 20;//set프로퍼티가 설정되지 않아 읽기 전용
        }
    }
}
