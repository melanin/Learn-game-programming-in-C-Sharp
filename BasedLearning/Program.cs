using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BasedLearning
{
    interface ISort
    {
        int GetY();
    }

    class GameObject : ISort
    {
        public int x;
        public int y;

        public int GetY()//인터페이스 ISort의 GetY() 구현
        {
            return y;
        }

        public void Print()
        {
            System.Console.WriteLine("===");
            System.Console.WriteLine("X = {0}", x);
            System.Console.WriteLine("Y = {0}", y);
            System.Console.WriteLine("===");
        }
    }

    class Core
    {
        public static void SortGameObject(ArrayList __list)
        {
            int min;
            int minIndex;
            object temp;

            for (int i = 0; i < __list.Count - 1; i++)
            {
                minIndex = i;
                min = ((ISort)__list[i]).GetY();
                temp = __list[i];

                for (int k = i + 1; k < __list.Count; k++)
                {
                    if (min > ((ISort)__list[k]).GetY())
                    {
                        min = ((ISort)__list[k]).GetY();
                        minIndex = k;
                    }
                }

                temp = __list[minIndex];
                __list[minIndex] = __list[i];
                __list[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            ArrayList list = new ArrayList();

            GameObject obj1 = new GameObject();
            obj1.x = rnd.Next(100);
            obj1.y = rnd.Next(100);

            GameObject obj2 = new GameObject();
            obj2.x = rnd.Next(100);
            obj2.y = rnd.Next(100);

            GameObject obj3 = new GameObject();
            obj3.x = rnd.Next(100);
            obj3.y = rnd.Next(100);

            GameObject obj4 = new GameObject();
            obj4.x = rnd.Next(100);
            obj4.y = rnd.Next(100);

            GameObject obj5 = new GameObject();
            obj5.x = rnd.Next(100);
            obj5.y = rnd.Next(100);

            list.Add(obj1);
            list.Add(obj2);
            list.Add(obj3);
            list.Add(obj4);
            list.Add(obj5);

            SortGameObject(list);

            for (int i = 0; i < list.Count; i++)
            {
                GameObject obj = (GameObject)list[i];
                obj.Print();
            }
        }
    }
}
