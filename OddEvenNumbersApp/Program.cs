using System;
using System.Collections.Generic;
using System.Linq;

namespace OddevenNumbersApp
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumbers("Numbers",Numbers);
            PrintNumbers("Even No",Numbers.Where(x=> IsEven(x)));
            PrintNumbers("Odd No", Numbers.Where(x => IsOdd(x)));
        }
        static void PrintNumbers(string Title , IEnumerable<int> Numbers)
        {
            Console.WriteLine();
            Console.Write($"{Title}: [");
            foreach(var n in Numbers)
            {
                Console.Write($" {n}");
            }
            Console.Write($" ]");
            Console.WriteLine();
        }
        static bool IsEven(int number) => number % 2 == 0;
        static bool IsOdd(int number) => !IsEven(number);
    }


}
