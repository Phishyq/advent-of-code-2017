using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day3Tests
    {
        private Day3Solution _itemUnderTest;

        [TestInitialize]
        public void TestSetup()
        {
            _itemUnderTest = new Day3Solution();
        }

        #region Part 1 Tests

        /// <summary>
        /// Data from square 1 is carried 0 steps, since it's at the access port.
        /// </summary>
        [TestMethod]
        public void Day3_Part1_Square1()
        {
            // Arrange
            int testInput = 1;

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// Data from square 12 is carried 3 steps, such as: down, left, left.
        /// </summary>
        [TestMethod]
        public void Day3_Part1_Square12()
        {
            // Arrange
            int testInput = 12;

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// Data from square 23 is carried only 2 steps: up twice.
        /// </summary>
        [TestMethod]
        public void Day3_Part1_Square23()
        {
            // Arrange
            int testInput = 23;

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Data from square 1024 must be carried 31 steps.
        /// </summary>
        [TestMethod]
        public void Day3_Part1_Square1024()
        {
            // Arrange
            int testInput = 1024;

            // Act
            var result = _itemUnderTest.SolvePart1(testInput);

            // Assert
            Assert.AreEqual(31, result);
        }

        #endregion

        #region Part 2 Tests

        // todo: these need fixing - they don't match what the question actually wants you to return.

        ///// <summary>
        ///// Square 1 starts with the value 1.
        ///// </summary>
        //[TestMethod]
        //public void Day3_Part2_Square1()
        //{
        //    // Arrange
        //    int testInput = 1;

        //    // Act
        //    var result = _itemUnderTest.SolvePart2(testInput);

        //    // Assert
        //    Assert.AreEqual(1, result);
        //}

        ///// <summary>
        ///// Square 2 has only one adjacent filled square (with value 1), so it also stores 1.
        ///// </summary>
        //[TestMethod]
        //public void Day3_Part2_Square2()
        //{
        //    // Arrange
        //    int testInput = 2;

        //    // Act
        //    var result = _itemUnderTest.SolvePart2(testInput);

        //    // Assert
        //    Assert.AreEqual(1, result);
        //}

        ///// <summary>
        ///// Square 3 has both of the above squares as neighbors and stores the sum of their values, 2.
        ///// </summary>
        //[TestMethod]
        //public void Day3_Part2_Square3()
        //{
        //    // Arrange
        //    int testInput = 3;

        //    // Act
        //    var result = _itemUnderTest.SolvePart2(testInput);

        //    // Assert
        //    Assert.AreEqual(2, result);
        //}

        ///// <summary>
        ///// Square 4 has all three of the aforementioned squares as neighbors and stores the sum of their values, 4.
        ///// </summary>
        //[TestMethod]
        //public void Day3_Part2_Square4()
        //{
        //    // Arrange
        //    int testInput = 4;

        //    // Act
        //    var result = _itemUnderTest.SolvePart2(testInput);

        //    // Assert
        //    Assert.AreEqual(4, result);
        //}

        ///// <summary>
        ///// Square 5 only has the first and fourth squares as neighbors, so it gets the value 5.
        ///// </summary>
        //[TestMethod]
        //public void Day3_Part2_Square5()
        //{
        //    // Arrange
        //    int testInput = 5;

        //    // Act
        //    var result = _itemUnderTest.SolvePart2(testInput);

        //    // Assert
        //    Assert.AreEqual(5, result);
        //}

        #endregion
    }
}
