using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BasedLearning
{
    class GameUser
    {
        public string name;
        public int energy;
    }

    class Core
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();//Hashtable

            GameUser user1 = new GameUser();
            user1.name = "c# USER";
            user1.energy = 100;

            GameUser user2 = new GameUser();
            user2.name = "HONG";
            user2.energy = 60;

            GameUser user3 = new GameUser();
            user3.name = "LIM";
            user3.energy = 150;

            table.Add(user1.name.GetHashCode(), user1);//Object::GetHashCode()사용
            table.Add(user2.name.GetHashCode(), user2);
            table.Add(user3.name.GetHashCode(), user3);

            GameUser player = (GameUser)table["c# USER".GetHashCode()];
            if (null != player)
            {
                System.Console.WriteLine(player.name);
                System.Console.WriteLine(player.energy);
            }
            else
            {
                System.Console.WriteLine("Can not find player!!");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("======== KEY LIST");
            
            foreach (int key in table.Keys)//ICollection타입의 Keys
            {
                System.Console.WriteLine(key);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("======== OBJ LIST");

            foreach (object obj in table.Values)//ICollection타입의 Values
            {
                GameUser item = (GameUser)obj;
                System.Console.WriteLine("[{0}], {1}, {2}", obj, item.name, item.energy);
            }
        }
    }
}
