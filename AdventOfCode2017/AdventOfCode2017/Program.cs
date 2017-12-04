using System;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            var Day4 = new Day4Solution();
            var input = Day4.GetInputFromFile();

            // Solve puzzle
            var result = Day4.SolvePart2(input);

            // Write result(s)
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
