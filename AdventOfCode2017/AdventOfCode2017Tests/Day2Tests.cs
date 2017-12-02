using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Day1;
using System.Collections.Generic;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day2Tests
    {
        private Day2Solution _itemUnderTest;

        [TestInitialize]
        public void TestSetup()
        {
            _itemUnderTest = new Day2Solution();
        }

        #region Part 1 Tests

        /// <summary>
        /// The first row's largest and smallest values are 9 and 1, and their difference is 8.
        /// </summary>
        [TestMethod]
        public void Day2_Part1_FirstRow()
        {
            // Arrange
            var testInput = new List<string>() { "5\t1\t9\t5" };

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(8, result);
        }

        /// <summary>
        /// The second row's largest and smallest values are 7 and 3, and their difference is 4.
        /// </summary>
        [TestMethod]
        public void Day2_Part1_SecondRow()
        {
            // Arrange
            var testInput = new List<string>() { "7\t5\t3" };

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(4, result);
        }

        /// <summary>
        /// The third row's difference is 6.
        /// </summary>
        [TestMethod]
        public void Day2_Part1_ThirdRow()
        {
            // Arrange
            var testInput = new List<string>() { "2\t4\t6\t8" };

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(6, result);
        }

        /// <summary>
        /// In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18.
        /// </summary>
        [TestMethod]
        public void Day2_Part1_AllRowsChecksum()
        {
            // Arrange
            var testInput = new List<string>() { "5\t1\t9\t5", "7\t5\t3", "2\t4\t6\t8" };

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(18, result);
        }

        #endregion

        #region Part 2 Tests

        /// <summary>
        /// In the first row, the only two numbers that evenly divide are 8 and 2; the result of this division is 4.
        /// </summary>
        [TestMethod]
        public void Day2_Part2_FirstRow()
        {
            // Arrange
            var testInput = new List<string>() { "5\t9\t2\t8" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(4, result);
        }

        /// <summary>
        /// In the second row, the two numbers are 9 and 3; the result is 3.
        /// </summary>
        [TestMethod]
        public void Day2_Part2_SecondRow()
        {
            // Arrange
            var testInput = new List<string>() { "9\t4\t7\t3" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// In the third row, the result is 2.
        /// </summary>
        [TestMethod]
        public void Day2_Part2_ThirdRow()
        {
            // Arrange
            var testInput = new List<string>() { "3\t8\t6\t5" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// In this example, the sum of the results would be 4 + 3 + 2 = 9.
        /// </summary>
        [TestMethod]
        public void Day2_Part2_AllRowsChecksum()
        {
            // Arrange
            var testInput = new List<string>() { "5\t9\t2\t8", "9\t4\t7\t3", "3\t8\t6\t5" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(9, result);
        }

        #endregion
    }
}
