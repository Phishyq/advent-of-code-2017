using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017
{
    public class Day3Solution
    {
        public int GetInputFromFile()
        {
            return int.Parse(File.ReadAllText("../../PuzzleInputs/Day3.txt"));
        }

        #region Part 1

        // You come across an experimental new kind of memory stored on an infinite two-dimensional grid. 
        // Each square on the grid is allocated in a spiral pattern starting at a location marked 1 and then counting up while spiraling outward.
        // For example, the first few squares are allocated like this:

        //  17  16  15  14  13
        //  18   5   4   3  12
        //  19   6   1   2  11
        //  20   7   8   9  10
        //  21  22  23---> ...

        // While this is very space-efficient (no squares are skipped), requested data must be carried back to square 1
        // (the location of the only access port for this memory system) by programs that can only move up, down, left, or right.
        // They always take the shortest path: the Manhattan Distance between the location of the data and square 1.

        public int SolvePart1(int input)
        {
            var memoryGrid = BuildMemoryGrid(input);

            var manhattenDistance = Math.Abs(memoryGrid[input].Item1) + Math.Abs(memoryGrid[input].Item2);

            return manhattenDistance;
        }

        private static Dictionary<int, Tuple<int, int>> BuildMemoryGrid(int input)
        {
            int stepsTaken = 1;
            int stepsToMove = 1;
            int xPosition = 0;
            int yPosition = 0;

            Dictionary<int, Tuple<int, int>> memoryGrid = new Dictionary<int, Tuple<int, int>>();

            var currentCoordinates = new Tuple<int, int>(xPosition, yPosition);
            memoryGrid.Add(stepsTaken, currentCoordinates);

            while (stepsTaken <= input)
            {
                // step right
                for (int i = 1; i <= stepsToMove; i++)
                {
                    xPosition++;
                    stepsTaken++;
                    var coordinates = new Tuple<int, int>(xPosition, yPosition);
                    memoryGrid.Add(stepsTaken, coordinates);
                }

                // step up
                for (int i = 1; i <= stepsToMove; i++)
                {
                    yPosition++;
                    stepsTaken++;
                    var coordinates = new Tuple<int, int>(xPosition, yPosition);
                    memoryGrid.Add(stepsTaken, coordinates);
                }

                stepsToMove++;

                // step left
                for (int i = 1; i <= stepsToMove; i++)
                {
                    xPosition--;
                    stepsTaken++;
                    var coordinates = new Tuple<int, int>(xPosition, yPosition);
                    memoryGrid.Add(stepsTaken, coordinates);
                }

                // step down
                for (int i = 1; i <= stepsToMove; i++)
                {
                    yPosition--;
                    stepsTaken++;
                    var coordinates = new Tuple<int, int>(xPosition, yPosition);
                    memoryGrid.Add(stepsTaken, coordinates);
                }

                stepsToMove++;
            }

            return memoryGrid;
        }

        #endregion

        #region Part 2

        // As a stress test on the system, the programs here clear the grid and then store the value 1 in square 1. 
        // Then, in the same allocation order as shown above, they store the sum of the values in all adjacent squares, including diagonals.

        // Once a square is written, its value does not change. Therefore, the first few squares would receive the following values:

        //  147  142  133  122   59
        //  304    5    4    2   57
        //  330   10    1    1   54
        //  351   11   23   25   26
        //  362  747  806--->   ...

        public int SolvePart2(int input)
        {
            var memoryGrid = BuildStressMemoryGrid(input);

            var result = memoryGrid.FirstOrDefault(s => s.Value >= input).Value;

            return result;
        }

        private static Dictionary<Tuple<int, int>, int> BuildStressMemoryGrid(int input)
        {
            int stepsTaken = 1;
            int stepsToMove = 1;
            int xPosition = 0;
            int yPosition = 0;

            var memoryGrid = new Dictionary<Tuple<int, int>, int>();

            var currentCoordinates = new Tuple<int, int>(xPosition, yPosition);
            memoryGrid.Add(currentCoordinates, stepsTaken);

            while (stepsTaken <= 50)
            {
                // step right
                for (int i = 1; i <= stepsToMove; i++)
                {
                    xPosition++;
                    stepsTaken++;
                    var coordinates = new Tuple<int, int>(xPosition, yPosition);

                    var sumOfNeighbours = FindSumOfNeighbours(memoryGrid, coordinates);

                    memoryGrid.Add(coordinates, sumOfNeighbours);
                }

                // step up
                for (int i = 1; i <= stepsToMove; i++)
                {
                    yPosition++;
                    stepsTaken++;
                    var coordinates = new Tuple<int, int>(xPosition, yPosition);

                    var sumOfNeighbours = FindSumOfNeighbours(memoryGrid, coordinates);

                    memoryGrid.Add(coordinates, sumOfNeighbours);
                }

                stepsToMove++;

                // step left
                for (int i = 1; i <= stepsToMove; i++)
                {
                    xPosition--;
                    stepsTaken++;
                    var coordinates = new Tuple<int, int>(xPosition, yPosition);

                    var sumOfNeighbours = FindSumOfNeighbours(memoryGrid, coordinates);

                    memoryGrid.Add(coordinates, sumOfNeighbours);
                }

                // step down
                for (int i = 1; i <= stepsToMove; i++)
                {
                    yPosition--;
                    stepsTaken++;
                    var coordinates = new Tuple<int, int>(xPosition, yPosition);

                    var sumOfNeighbours = FindSumOfNeighbours(memoryGrid, coordinates);

                    memoryGrid.Add(coordinates, sumOfNeighbours);
                }

                stepsToMove++;
            }

            return memoryGrid;
        }

        private static int FindSumOfNeighbours(Dictionary<Tuple<int, int>, int> memoryGrid, Tuple<int, int> currentCoordinates)
        {
            int currentX = currentCoordinates.Item1;
            int currentY = currentCoordinates.Item2;

            var listOfNeighbours = memoryGrid.Where(c => ((c.Key.Item1 == currentX - 1) && (c.Key.Item2 == currentY + 1)) ||
                                                         ((c.Key.Item1 == currentX - 1) && (c.Key.Item2 == currentY)) ||
                                                         ((c.Key.Item1 == currentX - 1) && (c.Key.Item2 == currentY - 1)) ||
                                                         ((c.Key.Item1 == currentX + 1) && (c.Key.Item2 == currentY + 1)) ||
                                                         ((c.Key.Item1 == currentX + 1) && (c.Key.Item2 == currentY)) ||
                                                         ((c.Key.Item1 == currentX + 1) && (c.Key.Item2 == currentY - 1)) ||
                                                         ((c.Key.Item1 == currentX) && (c.Key.Item2 == currentY + 1)) ||
                                                         ((c.Key.Item1 == currentX) && (c.Key.Item2 == currentY - 1)));

            return listOfNeighbours.Sum(c => c.Value);
        }

        #endregion

        #region Shared

        #endregion
    }
}
