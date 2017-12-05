using System;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            var Day5 = new Day5Solution();
            var input = Day5.GetInputFromFile();

            // Solve puzzle
            var result = Day5.SolvePart2(input);

            // Write result(s)
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
