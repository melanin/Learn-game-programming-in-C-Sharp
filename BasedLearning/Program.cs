using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;//for MethodInfo

namespace BasedLearning
{
    class Core
    {   
        class CustomMethod : Attribute
        {
            private string _methodname;

            public CustomMethod(string __name)
            {
                _methodname = __name;
            }

            public string GetName()
            {
                return _methodname;
            }
        }

        class Player
        {
            [CustomMethod("Punch")]
            public void Punch()
            {
                System.Console.WriteLine("Punch!");
            }

            [CustomMethod("Kick")]
            public void Kick()
            {
                System.Console.WriteLine("Kick!");
            }

            [CustomMethod("Finger")]
            public void Finger()
            {
                System.Console.WriteLine("Finger!");
            }
        }

        class PlayerEx : Player
        {
            [CustomMethod("Head")]
            public void Head()
            {
                System.Console.WriteLine("Head!");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            PlayerEx playerEx = new PlayerEx();

            Type type = player.GetType();

            foreach (MethodInfo info in type.GetMethods())
            {
                foreach (Attribute attr in info.GetCustomAttributes(true))
                {
                    if (attr is CustomMethod)
                    {
                        System.Console.WriteLine(info.Name);
                    }
                }
            }

            System.Console.WriteLine();

            type = playerEx.GetType();
            foreach (MethodInfo info in type.GetMethods())
            {
                foreach (Attribute attr in info.GetCustomAttributes(true))
                {
                    if (attr is CustomMethod)
                    {
                        System.Console.WriteLine(info.Name);
                    }
                }
            }
        }
    }
}
