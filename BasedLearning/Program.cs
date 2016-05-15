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

        class ImageException : Exception
        {
            public string _message;
            public int _imageIndex;

            public ImageException(string __message, int __imageIndex)
            {
                _message = __message;
                _imageIndex = __imageIndex;
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
                throw new ImageException("error LoadGraphics", 34);
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
            catch (ImageException e)
            {
                System.Console.WriteLine("Err Message: " + e.Message + ", Index: " + e._imageIndex);
            }

            System.Console.WriteLine("Engine end...");
        }
    }
}
