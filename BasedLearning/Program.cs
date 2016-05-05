using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Threading;

namespace BasedLearning
{
    class DefenseMachine
    {
        public string _name;
        public GameWorld _world;

        public DefenseMachine(GameWorld __world)
        {
            _world = __world;

            _world._defenseMachineAlerts += new GameWorld.DefenseMachineAlert(Alert);//다중 위임
        }

        public void Alert()
        {
            System.Console.WriteLine("[{0}] DEFCON", _name);
        }

        public void Update()
        {
            System.Console.WriteLine("name: {0}", _name);
        }
    }

    class GameWorld
    {
        public ArrayList _objects = new ArrayList();//오브젝트 리스트

        public delegate void DefenseMachineAlert();//DefenseMachine의 Alert()에 대한 위임자
        public DefenseMachineAlert _defenseMachineAlerts;//위임 객체

        public void Update()
        {
            int loopCount = _objects.Count;
            for (int i = 0; i < loopCount; i++)
            {
                ((DefenseMachine)_objects[i]).Update();
            }

            Random rnd = new Random();
            int ret = rnd.Next(100);
            if (80 < ret)
            {
                if (null != _defenseMachineAlerts)
                {
                    System.Console.WriteLine("observer count: {0}"
                        , _defenseMachineAlerts.GetInvocationList().Length
                        );
                    _defenseMachineAlerts();//위임 함수 실행
                    //등록된 DefenseMachine.Alert()를 실행
                }
            }
        }
    }
    class Core
    {
        [STAThread]
        static void Main(string[] args)
        {
            GameWorld world = new GameWorld();

            DefenseMachine bot1 = new DefenseMachine(world);
            bot1._name = "bot1";

            DefenseMachine bot2 = new DefenseMachine(world);
            bot2._name = "bot2";

            DefenseMachine bot3 = new DefenseMachine(world);
            bot3._name = "bot3";

            world._objects.Add(bot1);
            world._objects.Add(bot2);
            world._objects.Add(bot3);

            bool loop = true;
            while (loop)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("=== GameWorld Start ===");
                world.Update();
            }
        }
    }
}
