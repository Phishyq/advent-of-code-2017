using System;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            var Day6 = new Day6Solution();
            var input = Day6.GetInputFromFile();

            // Solve puzzle
            var result = Day6.SolvePart2(input);

            // Write result(s)
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
