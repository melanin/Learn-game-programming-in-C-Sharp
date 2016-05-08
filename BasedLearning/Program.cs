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

            GameObject[] list = new GameObject[4];
            list[0] = obj1;
            list[1] = obj2;
            list[2] = obj3;
            list[3] = obj4;

            bool loop = true;
            while (loop)
            {
                Thread.Sleep(1000);

                //obj1.Update();
                //obj2.Update();
                //obj3.Update();
                //obj4.Update();

                //obj1.Render();
                //obj2.Render();
                //obj3.Render();
                //obj4.Render();

                //obj1.PrintName();
                //obj2.PrintName();
                //obj3.PrintName();
                //obj4.PrintName();

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
