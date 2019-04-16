//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.
using System;
namespace CompareMasive
{
    class Program
    {
        static void Main()
        {    
            int[] arr1 = new int[5] { 7,66,71,2,3 };
            int n = arr1.Length;
            int c = arr1.Length - 1;
          
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Arreay is [{0}] = {1}", i, arr1[i]);         
            }
            Console.WriteLine();
            bool symetric = true;
            for (int a = 0; a < n; a++)
            {
                if (arr1[a] != arr1[c-a])
                {
                    symetric = false;
                }
            }
            if (symetric)
            {
                Console.WriteLine("Array is Symetric");
            }
            else {
                Console.WriteLine("Array is NOT  Symetric");
            }
            Console.WriteLine(); 

            int[] arr2 = new int[5] { 7, 31, 1, 5, 20 };
            int b = arr2.Length;
            int h = arr2.Length - 1;
            for (int d = 0; d<b; d++)
            {
                Console.WriteLine("Arreay is [{0}] = {1}", d, arr2[d]);
            }
            Console.WriteLine();
            bool symetric2 = true;
            for (int r = 0; r <=h; r++)
            {
                if (arr2[r] != arr2[h-r]) {
                    symetric2 = false;
                }
            }
            if (symetric2)
            {
                Console.WriteLine("Array is Symetric");
            }
            else
            {
                Console.WriteLine("Array is NOT Symetric");
            }
            Console.WriteLine();
            if (arr1 == arr2)
            {
                Console.WriteLine("Arrays are sames");
            }
            else {
                Console.WriteLine("Arrays are deferent");
            }
            Console.WriteLine();
        }
    }
}
