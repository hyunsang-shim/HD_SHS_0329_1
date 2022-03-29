using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 9; i+=3)
            {
                for(int j = 1; j<=9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("");
            }
        }
    }
}
