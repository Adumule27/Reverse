using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word: ");
            string user = Console.ReadLine();
            System.Console.WriteLine(reverse(user));

        }

        static string reverse(string text)
        {
            string newText = "";
            int count = 0;
            int textlength = text.Length;
            while (count < textlength)
            {
                newText = newText + text[textlength - count - 1];
                count += 1;

            }

            return newText;


        }
    }
}