using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day1Tests
    {
        private Day1Solution _itemUnderTest;

        [TestInitialize]
        public void TestSetup()
        {
            _itemUnderTest = new Day1Solution();
        }

        #region Part 1 Tests

        /// <summary>
        /// 1122 produces a sum of 3 (1 + 2) because the first digit (1) matches the second digit and the third digit (2) matches the fourth digit.
        /// </summary>
        [TestMethod]
        public void Day1_Part1_FindAllSets()
        {
            // Arrange
            var testInput = "1122";

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// 1111 produces 4 because each digit(all 1) matches the next.
        /// </summary>
        [TestMethod]
        public void Day1_Part1_Quadruplet()
        {
            // Arrange
            var testInput = "1111";

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(4, result);
        }

        /// <summary>
        /// 1234 produces 0 because no digit matches the next.
        /// </summary>
        [TestMethod]
        public void Day1_Part1_NoRepeatingNumbers()
        {
            // Arrange
            var testInput = "1234";

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// 91212129 produces 9 because the only digit that matches the next one is the last digit, 9.
        /// </summary>
        [TestMethod]
        public void Day1_Part1_CheckLastCharacter()
        {
            // Arrange
            var testInput = "91212129";

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(9, result);
        }

        #endregion

        #region Part 2 Tests

        /// <summary>
        /// 1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
        /// </summary>
        [TestMethod]
        public void Day1_Part2_AllMatch()
        {
            // Arrange
            var testInput = "1212";

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(6, result);
        }

        /// <summary>
        /// 1221 produces 0, because every comparison is between a 1 and a 2.
        /// </summary>
        [TestMethod]
        public void Day1_Part2_NoMatches()
        {
            // Arrange
            var testInput = "1221";

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// 123425 produces 4, because both 2s match each other, but no other digit has a match.
        /// </summary>
        [TestMethod]
        public void Day1_Part2_OnlyOneMatch()
        {
            // Arrange
            var testInput = "123425";

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(4, result);
        }

        /// <summary>
        /// 123123 produces 12.
        /// </summary>
        [TestMethod]
        public void Day1_Part2_AllMatch_LongerInput()
        {
            // Arrange
            var testInput = "123123";

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(12, result);
        }

        /// <summary>
        /// 12131415 produces 4.
        /// </summary>
        [TestMethod]
        public void Day1_Part2_SomeMatches()
        {
            // Arrange
            var testInput = "12131415";

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(4, result);
        }

        #endregion
    }
}
