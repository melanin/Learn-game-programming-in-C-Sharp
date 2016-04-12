using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasedLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] fileInfos = directoryInfo.GetFiles();

            foreach(FileInfo info in fileInfos)
            {
                System.Console.WriteLine(info.Name);
            }
        }
    }
}
