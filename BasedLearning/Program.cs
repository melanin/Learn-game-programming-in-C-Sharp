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
        private string _name;
        private int _level;
        private int _energy;

        public void SetName(string __name)
        {
            _name = __name;
        }
        public void SetLevel(int __level)
        {
            _level = __level;
        }
        public void SetEnergy(int __energy)
        {
            _energy = __energy;
        }

        public string GetName()
        {
            return _name;
        }
        public int GetLevel()
        {
            return _level;
        }
        public int GetEnergy()
        {
            return _energy;
        }

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
            knight.SetName("기사");
            knight.SetLevel(1);
            knight.SetEnergy(10);
            knight.PrintAllInformation();

            System.Console.WriteLine();

            Character wizard = new Character();
            wizard.SetName("마법사");
            wizard.SetLevel(2);
            wizard.SetEnergy(5);
            //wizard.PrintName();
            //wizard.PrintLevel();
            //wizard.PrintEnergy();
            wizard.PrintAllInformation();
        }
    }
}
