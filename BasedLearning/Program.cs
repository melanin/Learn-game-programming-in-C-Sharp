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
            this._name = __name;
            this._level = __level;
            this._energy = __energy;
        }
        public Character(Character __source)
        {
            this._name = __source._name;
            this._level = __source._level;
            this._energy = __source._energy;
        }

        public void SetName(string __name)
        {
            this._name = __name;
        }
        public void SetLevel(int __level)
        {
            this._level = __level;
        }
        public void SetEnergy(int __energy)
        {
            this._energy = __energy;
        }

        public string GetName()
        {
            return this._name;
        }
        public int GetLevel()
        {
            return this._level;
        }
        public int GetEnergy()
        {
            return this._energy;
        }

        public void PrintName()
        {
            System.Console.WriteLine("이름: {0}", this._name);
        }
        public void PrintLevel()
        {
            System.Console.WriteLine("레벨: {0}", this._level);
        }
        public void PrintEnergy()
        {
            System.Console.WriteLine("에너지: {0}", this._energy);
        }

        public void PrintAllInformation()
        {
            this.PrintName();
            this.PrintLevel();
            this.PrintEnergy();

            System.Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Character knight = new Character("기사", 2, 100);
            Character clone = new Character(knight);
            clone.SetLevel(1);
            clone.SetEnergy(10);

            knight.PrintAllInformation();
            clone.PrintAllInformation();
        }
    }
}
