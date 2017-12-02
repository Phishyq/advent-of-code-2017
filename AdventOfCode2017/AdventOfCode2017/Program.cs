using AdventOfCode2017.Day1;
using System;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            var Day2 = new Day2Solution();
            var input = Day2.GetInputFromFile();

            // Solve puzzle
            var result = Day2.SolvePart2(input);

            // Write result(s)
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
