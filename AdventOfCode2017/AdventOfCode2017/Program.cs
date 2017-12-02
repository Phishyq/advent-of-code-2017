using AdventOfCode2017.Day1;
using System;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            var Day1 = new Day1Solution();
            var input = Day1.GetInputFromFile();

            // Solve puzzle
            var result = Day1.SolvePart2(input);

            // Write result(s)
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
