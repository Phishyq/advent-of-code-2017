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

        // An urgent interrupt arrives from the CPU: it's trapped in a maze of jump instructions, and it would like assistance from any programs 
        // with spare cycles to help find the exit. The message includes a list of the offsets for each jump. Jumps are relative: 
        // -1 moves to the previous instruction, and 2 skips the next one. Start at the first instruction in the list.
        // The goal is to follow the jumps until one leads outside the list. In addition, these instructions are a little strange;
        // after each jump, the offset of that instruction increases by 1. So, if you come across an offset of 3,
        // you would move three instructions forward, but change it to a 4 for the next time it is encountered.
        // Positive jumps("forward") move downward; negative jumps move upward. 
        // How many steps does it take to reach the exit?

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
