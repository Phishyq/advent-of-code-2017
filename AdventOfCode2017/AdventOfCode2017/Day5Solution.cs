using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2017
{
    public class Day5Solution
    {
        public int[] GetInputFromFile()
        {
            return File.ReadLines("../../PuzzleInputs/Day5.txt").Select(s => Convert.ToInt32(s)).ToArray();
        }

        #region Part 1

        public int SolvePart1(int[] input)
        {
            int currentPosition = 0;
            int newPosition = 0;
            int stepsTaken = 0;

            while (newPosition < input.Length)
            {
                // follow instruction
                newPosition += input[currentPosition];
                // increment previous position
                input[currentPosition] += 1;
                // update location + step
                currentPosition = newPosition;
                stepsTaken++;
            }

            return stepsTaken;
        }


        #endregion

        #region Part 2

        // Now, the jumps are even stranger: after each jump, if the offset was three or more, 
        // instead decrease it by 1. Otherwise, increase it by 1 as before. 
        // How many steps does it now take to reach the exit?

        public int SolvePart2(int[] input)
        {
            int currentPosition = 0;
            int newPosition = 0;
            int stepsTaken = 0;

            while (newPosition < input.Length)
            {
                // follow instruction
                newPosition += input[currentPosition];
                // increment or decrement previous position
                input[currentPosition] += (input[currentPosition] < 3) ? 1 : -1;
                // update location + step
                currentPosition = newPosition;
                stepsTaken++;
            }

            return stepsTaken;
        }

        #endregion
    }
}
