using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;//for MethodInfo

namespace BasedLearning
{
    class Core
    {
        class LoadException : Exception
        {
            public string _message;

            public LoadException(string __message)
            {
                _message = __message;
            }
        }

        class Engine
        {
            public Engine()
            {
            }

            public bool LoadResource()
            {
                return true;
            }

            public bool LoadSounds()
            {
                return true;
            }

            public bool LoadGraphics()
            {
                throw new LoadException("error LoadGraphics");
                return false;
            }

            public bool LoadGameData()
            {
                return true;
            }

            public bool InitInput()
            {
                return true;
            }

            public void Update()
            {
            }

            public void Render()
            {
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Engine start...");

            Engine engine = new Engine();

            try
            {
                engine.LoadResource();
                engine.LoadSounds();
                engine.LoadGraphics();
                engine.LoadGameData();

                engine.Update();
                engine.Render();
            }
            catch (LoadException e)
            {
                System.Console.WriteLine(e.Message);
            }

            System.Console.WriteLine("Engine end...");
        }
    }
}
