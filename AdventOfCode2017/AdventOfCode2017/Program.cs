using System;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            var Day3 = new Day3Solution();
            var input = Day3.GetInputFromFile();

            // Solve puzzle
            var result = Day3.SolvePart2(input);

            // Write result(s)
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
