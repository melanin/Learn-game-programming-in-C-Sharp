using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

namespace BasedLearning
{
    abstract class Animal
    {
        abstract public void Eat();//abstract 추상 메서드는 내용을 구현하지 않고 파생클래스에 구현을 넘길 수 있음
    }

    class Person : Animal
    {
        public override void Eat()//상속받은 Animal의 추상 메서드 Animal.Eat()을 정의
        {
            //throw new NotImplementedException();
            System.Console.WriteLine("eat the rice");
        }
    }

    class Cyborg : Person
    {
        public override void Eat()
        {
            //base.Eat();
            System.Console.WriteLine("eat the spark");
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            //Animal obj = new Animal();//abstract 추상 클래스는 객체 생성 불가

            Person man = new Person();
            man.Eat();

            Cyborg bot = new Cyborg();
            bot.Eat();
        }
    }
}
