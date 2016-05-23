using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(
                //new Form1()
                //new LevelUp()
                //new Windows.CheckBoxEx()
                //new Windows.CheckBoxSample2()
                //new Windows.CheckBoxMediatorSample()
                new Windows.RadioButtonSample()
                );
        }
    }
}
