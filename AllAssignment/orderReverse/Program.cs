using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string sent = "This is a simple sentence";
            string[] sentList = sent.Split(" ");

            int len = sentList.Length;
            var don = new List<string>();
            for (int i = 0; i < len; i++)
            {
                    don.Insert(i,sentList[len-i-1]);
            }
            foreach(var j in don)
            {
                Console.Write(j+" ");
            }

        }

    }
}