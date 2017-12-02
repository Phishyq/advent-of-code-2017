using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Day1
{
    public class Day1Solution
    {
        public string GetInputFromFile()
        {
            return new StreamReader("../../PuzzleInputs/Day1.txt").ReadLine();
        }

        #region Part 1

        // You're standing in a room with "digitization quarantine" written in LEDs along one wall. The only door is locked, but it includes a small interface. 
        // "Restricted Area - Strictly No Digitized Users Allowed." It goes on to explain that you may only leave by solving a captcha to prove you're not a human. 
        // Apparently, you only get one millisecond to solve the captcha: too fast for a normal human, but it feels like hours to you.
        // The captcha requires you to review a sequence of digits(your puzzle input) and find the sum of all digits that match the next digit in the list.
        // The list is circular, so the digit after the last digit is the first digit in the list.

        public int SolvePart1(string inputString)
        {
            var inputAsCharArray = inputString.ToCharArray();

            var inputAsIntList = convertToIntList(inputAsCharArray);

            return SumRepeatingDigits(inputAsIntList);
        }

        private int SumRepeatingDigits(List<int> intList)
        {
            var runningTotal = 0;

            for (int i = 0; i < intList.Count - 1; i++)
            {
                if (intList[i] == intList[i + 1])
                {
                    runningTotal += intList[i];
                }
            }

            if (intList.First() == intList.Last())
            {
                runningTotal += intList.Last();
            }

            return runningTotal;
        }

        #endregion

        #region Part 2

        // You notice a progress bar that jumps to 50% completion. Apparently, the door isn't yet satisfied, but it did emit a star as encouragement. The instructions change:
        // Now, instead of considering the next digit, it wants you to consider the digit halfway around the circular list.
        // That is, if your list contains 10 items, only include a digit in your sum if the digit 10/2 = 5 steps forward matches it.
        // Fortunately, your list has an even number of elements.

        public int SolvePart2(string inputString)
        {
            var inputAsCharArray = inputString.ToCharArray();

            var inputAsIntList = convertToIntList(inputAsCharArray);

            return SumMidpointMatches(inputAsIntList);
        }

        private int SumMidpointMatches(List<int> intList)
        {
            var runningTotal = 0;

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == intList[(i + intList.Count / 2) % intList.Count])
                {
                    runningTotal += intList[i];
                }
            }

            return runningTotal;
        }

        #endregion

        #region Shared

        private List<int> convertToIntList(char[] charArray)
        {
            List<int> intList = new List<int>();

            foreach (char c in charArray)
            {
                intList.Add(Int32.Parse(c.ToString()));
            }

            return intList;
        }

        #endregion
    }
}
