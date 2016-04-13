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
        private int _energy = 100;

        public Character()
        {
        }
        public Character(string __name, int __level, int __energy)
        {
            _name = __name;
            _level = __level;
            _energy = __energy;
        }

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

            System.Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Character knight = new Character("기사님", 2, 100);
            Character mage = new Character("메이지", 5, 50);
            Character ranger = new Character("레인저", 1, 10);

            knight.PrintAllInformation();
            mage.PrintAllInformation();
            ranger.PrintAllInformation();
        }
    }
}
