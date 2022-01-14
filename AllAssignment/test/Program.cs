using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter your word for reverse: ");
      string word = Console.Read();
     
        string Reverser(string text)
      {
        string newText = "";
        var count = 0;
        var textLength = text.Length;
        while(count<textLength)
        {
            newText = newText + text[textLength - count - 1];
            count = count + 1;
            return newText;
        }

      }

      Reverser(word);
    }

   
  }
}