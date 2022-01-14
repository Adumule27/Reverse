using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string word = "abcde";
            var length = word.Length;
            string use = "";
            for (int i = 0; i < length; i++)
            {
                use = use + word[i];
                Console.WriteLine(use);
            }


        }


    }
}