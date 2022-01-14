using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "This is just a demonstrsation";
            IDictionary<int,string> d = new Dictionary<int, string>();
            
            foreach(var i in word)
            {
                var count = 1;
                foreach(var j in word)
                {
                    if(i == j)
                    {
                        d[i] = Convert.ToString(count);
                        count += 1;
                    }
                }
            }

                foreach(var kl in d)
                {
                    Console.WriteLine(kl);
                }
            

        }

    }
}