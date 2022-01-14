using System;
using System.Collections.Generic;


namespace palindrome 
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Enter the word: ");
            string user = Console.ReadLine();
            if (user == reverse(user))
			{	
				Console.WriteLine("Palindrome");
			}
			else
			{
				Console.WriteLine("Not Palindrome");
			}


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
