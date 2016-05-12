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
        class Player
        {
            public void Punch()
            {
                System.Console.WriteLine("puhch");
            }
            public void Kick()
            {
                System.Console.WriteLine("kick");
            }
            public void Finger()
            {
                System.Console.WriteLine("finger");
            }
        }

        class PlayerEx : Player
        {
            public void Head()
            {
                System.Console.WriteLine("head");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            PlayerEx playerEx = new PlayerEx();

            Type type = player.GetType();
            foreach (MethodInfo info in type.GetMethods())
            {
                System.Console.WriteLine(info.Name);
            }
            MethodInfo[] infos = type.GetMethods();
            System.Console.WriteLine("COUNT: {0}", infos.GetLength(0));
            System.Console.WriteLine();

            type = player.GetType();
            foreach (MethodInfo info in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                System.Console.WriteLine(info.Name);
            }
            infos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            System.Console.WriteLine("COUNT: {0}", infos.GetLength(0));
            System.Console.WriteLine();

            type = playerEx.GetType();
            foreach (MethodInfo info in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                System.Console.WriteLine(info.Name);
            }
            infos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            System.Console.WriteLine("COUNT: {0}", infos.GetLength(0));
        }
    }
}
