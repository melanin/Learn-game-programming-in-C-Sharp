using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "텍스트";
            int data = 1234;
            text += data.ToString();
            System.Console.WriteLine(text);

            int data2 = 5678;
            text += Convert.ToString(data2);
            System.Console.WriteLine(text);

            string numString = "1234";
            int number = Convert.ToInt32(numString);
            System.Console.WriteLine(number);

            try
            {
                string text2 = "123AAA4";
                int number2 = Convert.ToInt32(text2);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
