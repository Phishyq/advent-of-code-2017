using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017;
using System.Collections.Generic;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day5Tests
    {
        private Day5Solution _itemUnderTest;

        [TestInitialize]
        public void TestSetup()
        {
            _itemUnderTest = new Day5Solution();
        }

        #region Part 1 Tests

        /// <summary>
        /// (0) 3  0  1  -3  - before we have taken any steps.
        /// (1) 3  0  1  -3  - jump with offset 0 (that is, don't jump at all). Fortunately, the instruction is then incremented to 1.
        /// 2 (3) 0  1  -3  - step forward because of the instruction we just modified.The first instruction is incremented again, now to 2.
        /// 2  4  0  1 (-3) - jump all the way to the end; leave a 4 behind.
        /// 2 (4) 0  1  -2  - go back to where we just were; increment -3 to -2.
        /// 2  5  0  1  -2  - jump 4 steps forward, escaping the maze.
        /// In this example, the exit is reached in 5 steps.
        /// </summary>
        [TestMethod]
        public void Day5_Part1()
        {
            // Arrange
            var testInput = new int[] { 0, 3, 0, 1, -3 };

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(5, result);
        }

        #endregion

        #region Part 2 Tests

        [TestMethod]
        public void Day5_Part2()
        {
            // Arrange
            var testInput = new int[] { 0, 3, 0, 1, -3 };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(10, result);
        }

        #endregion
    }
}
