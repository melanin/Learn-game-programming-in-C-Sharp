using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BasedLearning
{
    class SimpleIntVector
    {
        private ArrayList data = new ArrayList();

        public void push_back(int __element)
        {
            data.Add(__element);
        }

        public int GetData(int __index)
        {
            return (int)data[__index];
        }

        //인덱서
        public int this[int __index]
        {
            get
            {
                return (int)data[__index];
            }
            set
            {
                if (__index >= data.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                data[__index] = value;
            }
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            SimpleIntVector vector = new SimpleIntVector();

            vector.push_back(1);
            vector.push_back(2);
            vector.push_back(5);
            vector.push_back(10);

            System.Console.WriteLine("{0} ", vector.GetData(2));

            vector[2] = 20;
            System.Console.WriteLine("{0} ", vector[2]);

            //vector[10] = 2;//IndexOutOfRangeException.. 할당되지 않은 위치에 값을 넣으면 exception 발생하도록 설정되어 있음
        }
    }
}
