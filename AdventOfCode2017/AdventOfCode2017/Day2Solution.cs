using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Day1
{
    public class Day2Solution
    {
        public IEnumerable<string> GetInputFromFile()
        {
            return File.ReadLines("../../PuzzleInputs/Day2.txt");
        }

        #region Part 1

        // As you walk through the door, a glowing humanoid shape yells in your direction. "You there! Your state appears to be idle. 
        // Come help us repair the corruption in this spreadsheet - if we take another millisecond, we'll have to display an hourglass cursor!"
        // The spreadsheet consists of rows of apparently-random numbers. To make sure the recovery process is on the right track, 
        // they need you to calculate the spreadsheet's checksum. For each row, determine the difference between the largest value and the smallest value; 
        // the checksum is the sum of all of these differences.

        public int SolvePart1(IEnumerable<string> inputStrings)
        {
            return FindHighLowChecksum(inputStrings);
        }
        private int FindHighLowChecksum(IEnumerable<string> allRows)
        {
            var runningTotal = 0;
            foreach (var row in allRows)
            {
                List<int> intList = ConvertRowToInts(row);

                intList.Sort();
                runningTotal += intList.Last() - intList.First();
            }

            return runningTotal;
        }

        #endregion

        #region Part 2

        // "Based on what we're seeing, it looks like all the User wanted is some information about the evenly divisible values in the spreadsheet.
        // Unfortunately, none of us are equipped for that kind of calculation - most of us specialize in bitwise operations."
        // It sounds like the goal is to find the only two numbers in each row where one evenly divides the other - that is,
        // where the result of the division operation is a whole number. They would like you to find those numbers on each line,
        // divide them, and add up each line's result.

        public int SolvePart2(IEnumerable<string> inputString)
        {
            return FindDivisibleChecksum(inputString);
        }

        private int FindDivisibleChecksum(IEnumerable<string> allRows)
        {
            var runningTotal = 0;
            foreach (var row in allRows)
            {
                List<int> intList = ConvertRowToInts(row);

                for (int i = 0; i < intList.Count; i++)
                {
                    var divisible = intList.Where(d => d % intList[i] == 0 && d != intList[i]).FirstOrDefault();
                    if (divisible != 0)
                    {
                        runningTotal += (divisible / intList[i]);
                    }
                }
            }

            return runningTotal;
        }

        #endregion

        #region Shared

        private static List<int> ConvertRowToInts(string row)
        {
            var intList = new List<int>();
            var rowValues = row.Split('\t');

            foreach (var value in rowValues)
            {
                intList.Add(Int32.Parse(value));
            }

            return intList;
        }

        #endregion
    }
}
