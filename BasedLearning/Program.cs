using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BasedLearning
{
    class Core
    {
        static void PrintAll(IEnumerator<int> __stack)
        {
            __stack.Reset();//Stack의 첫번째 요소에 열거자 설정
            System.Console.Write("Stack Data => ");
            while (__stack.MoveNext())//Stack의 다음 요소로 이동
            {
                System.Console.Write("{0} ", __stack.Current);//Stack의 현재 요소 출력
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();//Generic Stack.. int형 고정

            data.Push(1);
            data.Push(2);
            data.Push(3);

            PrintAll(data.GetEnumerator());//Stack의 열거자를 인자로 넘김

            data.Push(9);
            PrintAll(data.GetEnumerator());

            data.Push(10);
            PrintAll(data.GetEnumerator());

            int ret = data.Pop();//마지막으로 들어간 요소를 Stack에서 빼냄
            System.Console.WriteLine("POP: {0}", ret);
            PrintAll(data.GetEnumerator());

            ret = data.Pop();
            System.Console.WriteLine("POP: {0}", ret);
            PrintAll(data.GetEnumerator());

            //////////////////////////////
            Stack data2 = new Stack();//Non-Generic Stack.. Object타입을 넣을 수 있다
            data2.Push(100);
            data2.Push("ABC");
        }
    }
}
