using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017;
using System.Collections.Generic;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day4Tests
    {
        private Day4Solution _itemUnderTest;

        [TestInitialize]
        public void TestSetup()
        {
            _itemUnderTest = new Day4Solution();
        }

        #region Part 1 Tests

        /// <summary>
        /// aa bb cc dd ee is valid.
        /// </summary>
        [TestMethod]
        public void Day4_Part1_Valid()
        {
            // Arrange
            var testInput = new List<string> { "aa bb cc dd ee" };

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// aa bb cc dd aa is not valid - the word aa appears more than once.
        /// </summary>
        [TestMethod]
        public void Day4_Part1_Invalid()
        {
            // Arrange
            var testInput = new List<string> { "aa bb cc dd aa" };

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// aa bb cc dd aaa is valid - aa and aaa count as different words.
        /// </summary>
        [TestMethod]
        public void Day4_Part1_ValidPartialMatch()
        {
            // Arrange
            var testInput = new List<string> { "aa bb cc dd aaa" };

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(1, result);
        }

        #endregion

        #region Part 2 Tests

        /// <summary>
        /// abcde fghij is a valid passphrase.
        /// </summary>
        [TestMethod]
        public void Day4_Part2_Valid()
        {
            // Arrange
            var testInput = new List<string> { "abcde fghij" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// abcde xyz ecdab is not valid - the letters from the third word can be rearranged to form the first word.
        /// </summary>
        [TestMethod]
        public void Day4_Part2_Invalid()
        {
            // Arrange
            var testInput = new List<string> { "abcde xyz ecdab" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// a ab abc abd abf abj is a valid passphrase, because all letters need to be used when forming another word.
        /// </summary>
        [TestMethod]
        public void Day4_Part2_ValidPartialMatch()
        {
            // Arrange
            var testInput = new List<string> { "a ab abc abd abf abj" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// iiii oiii ooii oooi oooo is valid.
        /// </summary>
        [TestMethod]
        public void Day4_Part2_ValidNoMatches()
        {
            // Arrange
            var testInput = new List<string> { "iiii oiii ooii oooi oooo" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// oiii ioii iioi iiio is not valid - any of these words can be rearranged to form any other word.
        /// </summary>
        [TestMethod]
        public void Day4_Part2_InvalidMultipleMatches()
        {
            // Arrange
            var testInput = new List<string> { "oiii ioii iioi iiio" };

            // Act
            var result = _itemUnderTest.SolvePart2(testInput);

            // Assert
            Assert.AreEqual(0, result);
        }

        #endregion
    }
}
