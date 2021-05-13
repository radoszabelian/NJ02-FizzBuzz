using System;

namespace NJ02_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 100; n++)
            {
                string r = "";
                if (n % 3 == 0) r += "Fizz ";
                if (n % 5 == 0) r += "Buzz";
                if (r.Length == 0) r += n;
                Console.WriteLine(r);
            }
        }
    }
}
