using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WinForm
{
    class Program
    {
        static void Main(string[] args)
        {
            MainForm form = new MainForm();
            //Thread.Sleep(5000);

            bool loop = true;
            while (loop)
            {
                Thread.Sleep(30);
                System.Windows.Forms.Application.DoEvents();
            }
        }
    }
}
