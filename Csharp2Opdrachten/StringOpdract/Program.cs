using System;
using System.IO;
namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringText = File.ReadAllText(@"C:\Users\nikki\OneDrive\Desktop\School\2022P4csharp\Csharp2Opdrachten\StringOpdract\Stringsplit.txt");
            string[] text = stringText.Split(':', ',');

            foreach (string textt in text)
            {
                Console.WriteLine(textt);
            }
        }
    }
}