using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BasedLearning
{
    struct Vec
    {
        private float x;
        private float y;

        public Vec(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X
        {
            get
            {
                return x;
            }
            set
            {
                y = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }       

        public void PrintAll()
        {
            System.Console.WriteLine("X = {0}, Y = {1}", x, y);
        }

        public static Vec operator -(Vec lhs, Vec rhs)
        {
            return new Vec(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            Vec a = new Vec(10, 10);
            a.PrintAll();

            Vec b = new Vec(100, 100);
            b.PrintAll();

            Vec c = b - a;
            c.PrintAll();
        }
    }
}
