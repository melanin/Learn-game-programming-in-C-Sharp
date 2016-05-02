using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasedLearning
{
    class Data
    {
        public int a;
        public int b;
    }

    class Core
    {
        static void Calc(Data __obj)
        {
            __obj.a = 100;
            __obj.b = 200;
        }

        static void Main(string[] args)
        {
            Data obj = new Data();
            obj.a = 10;
            obj.b = 20;

            System.Console.WriteLine("초기값 {0}, {1}", obj.a, obj.b);

            Calc(obj);
            System.Console.WriteLine("결과 {0}, {1}", obj.a, obj.b);//기본 타입을 제외한 타입은 reference로 전달
        }
    }
}
