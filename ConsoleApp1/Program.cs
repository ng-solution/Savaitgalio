using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = Environment.UserName;
            for (int i=0; i<100; i++)
            Console.WriteLine(vardas);
        }
    }
}
