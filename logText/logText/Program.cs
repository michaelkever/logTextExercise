using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C:\Users\micha\OneDrive\Desktop\TextDocs\logText.txt", userInput);
            Console.WriteLine("The number you logged:");
            string userText = File.ReadAllText(@"C:\Users\micha\OneDrive\Desktop\TextDocs\logText.txt" );
            Console.WriteLine(userText);
            Console.ReadLine();
        }
    }
}
