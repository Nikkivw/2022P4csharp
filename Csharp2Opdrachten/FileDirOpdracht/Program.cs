using System;
using System.IO;
namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\nikki\OneDrive\Desktop\School\2022P4csharp\Csharp2Opdrachten\FileDirOpdracht");
            Console.WriteLine("No search pattern returns:");
            foreach (DirectoryInfo fil in dir.GetDirectories())
            {
                Console.WriteLine(fil.Name);
            }

            Console.WriteLine();

            foreach (FileInfo fil in dir.GetFiles())
            {
                Console.WriteLine(fil.Name);
            }

        }
    }
}