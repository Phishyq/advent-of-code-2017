using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017
{
    public class Day6Solution
    {
        public string GetInputFromFile()
        {
            return File.ReadAllText("../../PuzzleInputs/Day6.txt");
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

        public int SolvePart1(string input)
        {
            int numberOfCycles = 0;
            bool previousDistributionMatched = false;
            List<int[]> previousDistributions = new List<int[]>();
            var memoryBank = input.Split('\t').Select(s => Convert.ToInt32(s)).ToList();

            while (!previousDistributionMatched)
            {
                // find bank with most blocks (ties won by lowest numbered element)
                var maxBankIndex = memoryBank.IndexOf(memoryBank.Max());

                // redistribute content into other blocks starting with next
                var blocksToRedistribute = memoryBank[maxBankIndex];
                memoryBank[maxBankIndex] = 0;
                var indexToUpdate = maxBankIndex + 1;

                for (int b = blocksToRedistribute; b > 0; b--)
                {
                    if (indexToUpdate > memoryBank.Count - 1)
                    {
                        indexToUpdate = 0;
                    }

                    memoryBank[indexToUpdate] += 1;
                    indexToUpdate++;
                }

                // check if new distribution has occured before
                foreach (var previousDistribution in previousDistributions)
                {
                    if (previousDistribution.SequenceEqual(memoryBank.ToArray()))
                    {
                        previousDistributionMatched = true;
                        break;
                    }
                }

                // store new distribution
                previousDistributions.Add(memoryBank.ToArray());
                numberOfCycles++;
            }

            return numberOfCycles;
        }

        #endregion

        #region Part 2

        // Out of curiosity, the debugger would also like to know the size of the loop: starting from a state that has already been seen,
        // how many block redistribution cycles must be performed before that same state is seen again?
        // How many cycles are in the infinite loop that arises from the configuration in your puzzle input?

        public int SolvePart2(string input)
        {
            int numberOfCycles = 0;
            bool previousDistributionMatched = false;
            List<int[]> previousDistributions = new List<int[]>();
            int previousDistributionIndex = 0;
            var memoryBank = input.Split('\t').Select(s => Convert.ToInt32(s)).ToList();

            while (!previousDistributionMatched)
            {
                // find bank with most blocks (ties won by lowest numbered element)
                var maxBankIndex = memoryBank.IndexOf(memoryBank.Max());

                // redistribute content into other blocks starting with next
                var blocksToRedistribute = memoryBank[maxBankIndex];
                memoryBank[maxBankIndex] = 0;
                var indexToUpdate = maxBankIndex + 1;

                for (int b = blocksToRedistribute; b > 0; b--)
                {
                    if (indexToUpdate > memoryBank.Count - 1)
                    {
                        indexToUpdate = 0;
                    }

                    memoryBank[indexToUpdate] += 1;
                    indexToUpdate++;
                }

                // check if new distribution has occured before
                foreach (var previousDistribution in previousDistributions)
                {
                    if (previousDistribution.SequenceEqual(memoryBank.ToArray()))
                    {
                        previousDistributionIndex = previousDistributions.IndexOf(previousDistribution);
                        previousDistributionMatched = true;
                        break;
                    }
                }

                // store new distribution
                previousDistributions.Add(memoryBank.ToArray());
                numberOfCycles++;
            }

            return numberOfCycles - previousDistributionIndex - 1;
        }

        #endregion
    }
}
