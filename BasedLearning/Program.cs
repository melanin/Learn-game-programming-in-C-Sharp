using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasedLearning
{
    class Animal
    {
    }

    class Person : Animal
    {
        //private string _name;//private는 상속받은 클래스도 접근 불가
        protected string _name;//protected는 상속받은 클래스만 접근 가능
        protected int _eye;
        protected int _ear;
        protected int _mouth;
        protected int _nose;

        public void Print()
        {
            System.Console.WriteLine("name is {0}", _name);
            System.Console.WriteLine("eye is {0}", _eye);
            System.Console.WriteLine("ear is {0}", _ear);
            System.Console.WriteLine("mouth is {0}", _mouth);
            System.Console.WriteLine("nose is {0}", _nose);
        }
    }

    class Cyborg : Person
    {
        private int _power;

        public void Set(string __name, int __eye, int __ear, int __mouth, int __nose)
        {
            _name = __name;
            _eye = __eye;
            _ear = __ear;
            _mouth = __mouth;
            _nose = __nose;
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            Cyborg smith = new Cyborg();
            smith.Set("Smith", 0, 10, 15, 7);
            //smith._power = 100;

            smith.Print();
        }
    }
}
