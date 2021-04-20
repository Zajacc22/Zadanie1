using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            int i;
            Console.WriteLine("Podaj liczbe:");
            i = int.Parse(Console.ReadLine());
            if (i % 3 == 0)
            {
                result += "fizz";
            }
            if (i % 5 == 0)
            {
                result += "buzz";
            }
            if (result == "")
            {
                Console.WriteLine(i);
            }
            else Console.WriteLine(result);
        }
    }
}
