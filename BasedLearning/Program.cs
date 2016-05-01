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
        public static int GetValue(ref int __param)
        {
            __param++;
            return __param;
        }

        public static int GetValue2(out int __param)
        {
            __param = 20;
            return __param;
        }

        //public static int GetValue3(out int __param)
        //{
        //    __param++;//out 키워드에 값을 할당하는 것이 아닌 변경하려는 시도는 불가
        //    return __param;
        //}

        static void Main(string[] args)
        {
            int param/* = 2*/;
            //int ret = GetValue(ref param);//초기화 되지 않은 변수를 ref로 전달 불가

            //System.Console.WriteLine(param);
            //System.Console.WriteLine(ret);

            int param2;
            int ret2 = GetValue2(out param2);

            System.Console.WriteLine(param2);
            System.Console.WriteLine(ret2);
        }
    }
}
