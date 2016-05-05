using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

namespace BasedLearning
{
    class Animal
    {
        protected string _name;

        public void SetName(string __name)
        {
            _name = __name;
        }

        public virtual void Eat()//virtual 가상함수
        {
            System.Console.WriteLine("[{0}] eat the rice", _name);
        }
    }

    class Person : Animal
    {
    }

    class Cyborg : Person
    {
        public override void Eat()//가상함수 override
        {
            base.Eat();//base 클래스 함수 호출
            System.Console.WriteLine("[{0}] eat the spark", _name);
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Person jack = new Person();
            jack.SetName("Jack");

            Person kelly = new Person();
            kelly.SetName("Kelly");

            Person kim = new Person();
            kim.SetName("Kim");

            Cyborg smith = new Cyborg();
            smith.SetName("Smith");

            list.Add(jack);
            list.Add(kelly);
            list.Add(kim);
            list.Add(smith);

            bool loop = true;
            while (loop)
            {
                Thread.Sleep(1000);

                //for (int i = 0; i < list.Count; i++)
                //{
                //    ((Animal)list[i]).Eat();
                //}

                foreach (Animal character in list)
                {
                    character.Eat();
                }
            }
        }
    }
}
