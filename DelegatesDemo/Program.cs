using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    class Program
    {
        delegate bool MeDelegate(int n);
        static bool LessThanFive(int n) { return n < 5; }
        static bool GreaterThanTen(int n) { return n > 10; }

        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 2, 5, 23, 26, 32, 12, 56, 6, 8, 4, 2, };
            var result = RunNumbersThroughGauntlet(numbers, GreaterThanTen);

            foreach(var n in result)
            {
                Console.WriteLine(n);
            }
        }

        static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            foreach(int number in numbers)
            {
                if (gauntlet(number))
                    yield return number;
            }
        }
    }
}
