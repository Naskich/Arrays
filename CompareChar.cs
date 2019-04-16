using System;
using System.Collections.Generic;

//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically(letter by letter).

namespace ComapreArrayChar
{
    class Program
    {
        static void Main()
        {
            char[] char1 = new char[5] { 'a', 'b', 'c', 'd', 'h' };

            char[] char2 = new char[5] { 'a', 'n', 'd', 'r', 'h' };
            foreach (char simbol1 in char1)
            {
                System.Console.Write("{0}", simbol1);
            }
            Console.WriteLine("- Array1");
            foreach (char simbol2 in char2)
            {
                System.Console.Write("{0}", simbol2);
            }
            Console.WriteLine("-Array2");

            if (char1[0] != char2[0])
            {
                Console.WriteLine("First element - FALSE - {0} DEFERENT {1}", char1[0], char2[0]);
            }
           else
            {
                Console.WriteLine("First element is TRUE - {0} = {1}", char1[0], char2[0]); 
            }
            Console.WriteLine();
            if (char1[1] != char2[1])
            {
                Console.WriteLine("Second element - FALSE - {0} DEFERENT {1}", char1[1], char2[1]);
            }
            else
            {
                Console.WriteLine("Second element is TRUE - {0} = {1}", char1[1], char2[1]);
            }
            Console.WriteLine();
            if (char1[2] != char2[2])
            {
                Console.WriteLine("Thirt element - FALSE - {0} DEFERENT {1}", char1[2], char2[2]);
            }
            else
            {
                Console.WriteLine("Thirt element is TRUE - {0} = {1}", char1[2], char2[2]);
            }
            Console.WriteLine();
            if (char1[3] != char2[3])
            {
                Console.WriteLine("Fuor element - FALSE - {0} DEFERENT {1}", char1[3], char2[3]);
            }
            else
            {
                Console.WriteLine("Thirt element is TRUE - {0} = {1}", char1[3], char2[3]);
            }
            Console.WriteLine();
            if (char1[4] != char2[4])
            {
                Console.WriteLine("Thirt element - FALSE - {0} DEFERENT {1}", char1[4], char2[4]);
            }
            else
            {
                Console.WriteLine("Thirt element is TRUE - {0} = {1}", char1[4], char2[4]);
            }
            Console.WriteLine();
        }
    }
}

