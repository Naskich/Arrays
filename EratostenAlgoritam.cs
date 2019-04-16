//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range[1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
using System;
namespace EratosthenesАlgorithm
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10000000];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[4] = 5;
            array[6] = 7;
            array[9999999] = 10000000;
            Console.WriteLine("ARRAY = {0}", array[1]);
            Console.WriteLine("ARRAY = {0}", array[2]);
            Console.WriteLine("ARRAY = {0}", array[4]);
            Console.WriteLine("ARRAY = {0}", array[6]);
            for (var a = 2; a < 10000000; a++)
            {
                if (a % 2 != 0 && a % 3 != 0 && a % 5 != 0 && a % 7 != 0)
                {
                    Console.WriteLine("ARRAY = {0}", a);
                }
            }
            Console.WriteLine();
        }
    }
}