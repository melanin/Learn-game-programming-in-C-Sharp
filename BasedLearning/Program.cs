using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasedLearning
{
    class Monster
    {
        public string _name;
        public int _energy;
        public static int _count;//객체가 같은 값을 공유

        public Monster()
        {
            _count++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Monster mob1 = new Monster();
            mob1._name = "고블린";
            mob1._energy = 10;

            Monster mob2 = new Monster();
            mob2._name = "오우거";
            mob2._energy = 20;

            //System.Console.WriteLine("총 몬스터 개수: {0}", mob1._count);//static 멤버는 객체로부터 접근 불가
            //Monster._count += 2;//static 멤버는 클래스 자체를 통해서 접근 가능.. 생성자에서 자동 카운트 중
            System.Console.WriteLine("총 몬스터 개수: {0}", Monster._count);

            System.Console.WriteLine("이름: {0}, 에너지: {1}", mob1._name, mob1._energy);
            System.Console.WriteLine("이름: {0}, 에너지: {1}", mob2._name, mob2._energy);
        }
    }
}
