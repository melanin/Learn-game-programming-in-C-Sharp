using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasedLearning
{
    struct Data
    {
        public int a;
        public int b;
        public int c;       
    }

    struct Data2 //: Data
    {//상속 불가
        public int d;
        //public int e = 10;//초기자 불가

        //public Data2() {}
        //생성자 사용 불가
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data data;
            data.a = 10;
            data.b = 20;
            data.c = 30;

            System.Console.WriteLine(data.a);
            System.Console.WriteLine(data.b);
            System.Console.WriteLine(data.c);

            Data2 data2;
            //System.Console.WriteLine(data2.d);//초기화 되지 않은 변수는 사용 불가

            Data2 data2_1 = new Data2();
            System.Console.WriteLine(data2_1.d);//new를 이용해서 생성한 객체는 내부의 기본 생성자에 의해 0으로 자동 초기화
        }
    }
}
