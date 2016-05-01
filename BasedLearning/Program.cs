using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasedLearning
{
    class Core
    {
        public static int GetValue(int __param)
        {
            __param++;
            return __param;
        }

        static void Main(string[] args)
        {
            int param = 2;
            int ret = GetValue(param);

            System.Console.WriteLine(param);//param이 call by value로 전달되어 GetValue를 호출해도 변경되지 않는다
            System.Console.WriteLine(ret);
        }
    }
}
