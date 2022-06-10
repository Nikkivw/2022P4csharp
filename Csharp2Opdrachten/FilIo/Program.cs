using System;
using System.IO;
namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Text = File.ReadAllLines(@"C:\Users\nikki\OneDrive\Desktop\School\2022P4csharp\Csharp2Opdrachten\FilIo\Randomtext.txt");

            foreach (string Line in Text)
                Console.WriteLine(Line);
        }
    }
}