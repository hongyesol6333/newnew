using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
