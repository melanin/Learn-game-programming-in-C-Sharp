using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasedLearning
{
    class Program
    {
        public const int ConstVar = 10;
        public readonly int ROvar1;//초기화하지 않아도 된다
        public readonly int ROvar2 = 1000;
        public readonly int ROvar3;
        public readonly int ROvar4;

        public Program()
        {
            //ConstVar = 20;//const 상수값 재정의 실패

            {//readonly값은 생성자에서만 값 대입 가능
                ROvar2 = 2000;//선언부에서 초기화 했어도 생성자 내에서는 변경 가능
                ROvar3 = 20000;
            }
        }

        public Program(int __type)
        {
            if (0 == __type)
            {
                ROvar4 = 30000;
            }
            else
            {
                ROvar4 = 40000;
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            {//초기화 되지않은 값은 0으로 출력
                System.Console.WriteLine(obj.ROvar1);
                System.Console.WriteLine(obj.ROvar4);
            }

            System.Console.WriteLine(obj.ROvar2);
            System.Console.WriteLine(obj.ROvar3);

            {//생성자에서 인자값으로 다른 값 설정의 예
                Program obj2 = new Program(0);
                System.Console.WriteLine(obj2.ROvar4);

                Program obj3 = new Program(1);
                System.Console.WriteLine(obj3.ROvar4);
            }

            {//readonly 값 변경 불가
                //ROvar1 = 500;
                //ROvar2 = 3000;
                //ROvar3 = 50000;
                //ROvar4 = 500000;
            }
        }
    }
}
