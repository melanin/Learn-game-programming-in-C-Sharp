using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasedLearning
{
    public class Character
    {
        public string _name;
        public int _level;
        public int _energy;

        public void PrintName()
        {
            System.Console.WriteLine("이름: {0}", _name);
        }
        public void PrintLevel()
        {
            System.Console.WriteLine("레벨: {0}", _level);
        }
        public void PrintEnergy()
        {
            System.Console.WriteLine("에너지: {0}", _energy);
        }

        public void PrintAllInformation()
        {
            PrintName();
            PrintLevel();
            PrintEnergy();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Character knight = new Character();
            knight._name = "기사";
            knight._level = 1;
            knight._energy = 10;
            //knight.PrintName();
            //knight.PrintLevel();
            //knight.PrintEnergy();
            knight.PrintAllInformation();

            System.Console.WriteLine();

            Character wizard = new Character();
            wizard._name = "마법사";
            wizard._level = 2;
            wizard._energy = 5;
            //wizard.PrintName();
            //wizard.PrintLevel();
            //wizard.PrintEnergy();
            wizard.PrintAllInformation();
        }
    }
}
