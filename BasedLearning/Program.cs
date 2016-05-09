using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BasedLearning
{
    class GameObject
    {
        private string _name;

        public GameObject(string __name)
        {
            _name = __name;
        }

        public void PrintName()
        {
            System.Console.WriteLine("Name is {0}", _name);
        }

        public void Update()
        {
            System.Console.WriteLine("{0} is Running", _name);
        }

        public void Render()
        {
            System.Console.WriteLine("{0} is Draw", _name);
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            GameObject obj1 = new GameObject("Smith");
            GameObject obj2 = new GameObject("Jack");
            GameObject obj3 = new GameObject("Kelly");
            GameObject obj4 = new GameObject("Kim");

            GameObject[] list = new GameObject[4] { obj1, obj2, obj3, obj4 };

            bool loop = true;
            while (loop)
            {
                Thread.Sleep(1000);

                for (int i = 0; i < list.Length; i++)
                {
                    list[i].Update();
                    list[i].Render();
                    list[i].PrintName();
                }
            }
        }
    }
}
