using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

namespace BasedLearning
{
    struct Vector2D
    {
        public double x;
        public double y;

        public Vector2D(double __x, double __y)
        {
            x = __x;
            y = __y;
        }

        //Vector의 길이 반환
        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        //인자의 벡터와의 거리 반환
        public double Distance(Vector2D __value)
        {
            return Math.Sqrt(
                Math.Pow(Math.Abs(__value.x - x), 2) + Math.Pow(Math.Abs(__value.y - y), 2)
                );
        }

        //__from에서 __to로 향하는 벡터 반환
        public static Vector2D DirectionVector(Vector2D __from, Vector2D __to)
        {
            Vector2D direction;
            direction.x = __to.x - __from.x;
            direction.y = __to.y - __from.y;

            return direction;
        }

        //벡터 정규화
        public void Normalize()
        {
            double length = Length();
            if (0 == length)
            {
                length = 1;
            }

            x /= length;
            y /= length;
        }
    }

    class MoveCommand
    {
        private Vector2D _vector;

        public MoveCommand(Vector2D __vector)
        {
            _vector = __vector;
        }

        public Vector2D GetPosition()
        {
            return _vector;
        }
    }

    class Core
    {
        static void Main(string[] args)
        {
            const double Speed = 2;

            Queue<MoveCommand> move = new Queue<MoveCommand>();//Generic QUEUE

            //이동 구간 설정
            move.Enqueue(new MoveCommand(new Vector2D(100, 0)));
            move.Enqueue(new MoveCommand(new Vector2D(50, 150)));
            move.Enqueue(new MoveCommand(new Vector2D(10, 200)));

            Vector2D goal = new Vector2D(10, 10);//첫번째 시작점
            Vector2D current = new Vector2D(0, 0);//현재 좌표.. 0, 0에서 시작

            while (true)
            {
                Thread.Sleep(300);

                System.Console.WriteLine("now position: X = {0}, Y = {1}", current.x, current.y);

                double distance = current.Distance(goal);

                if (1 >= distance)//거리가 1이하이면 목적지에 도착
                {
                    MoveCommand getData = null;
                    if (0 == move.Count)
                    {//이동할 곳이 없으면 종료
                        break;
                    }

                    getData = move.Dequeue();//QUEUE상의 첫번째 목적지를 받아옴

                    goal = getData.GetPosition();//받아온 목적지를 목표지점으로 결정
                    getData = null;
                    System.Console.WriteLine("gogo {0}, {1}", goal.x, goal.y);
                }
                else
                {//방향 벡터를 받아서 이동
                    Vector2D direction = Vector2D.DirectionVector(current, goal);
                    direction.Normalize();

                    current.x += (direction.x * Speed);
                    current.y += (direction.y * Speed);
                }
            }
            move = null;

            Queue queue = new Queue();//Non-Generic QUEUE
            queue.Enqueue(100);
            queue.Enqueue("ABC");
            queue.Enqueue(350.415);
        }
    }
}
