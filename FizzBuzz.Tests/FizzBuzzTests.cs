using NUnit.Framework;
using System;
using System.Linq;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_DoesNotCreateInstanceWhenEndIsLessThanStart()
        {
            #region Arrange
            int start = 2;
            int end = 1;

            #endregion

            #region Act

            #endregion

            #region Assert
            Assert.Throws<Exception>(() => { FizzBuzz fizzBuzz = new FizzBuzz(end, start); });
            #endregion
        }

        [Test]
        public void FizzBuzz_CreateInstanceWhenStartsLessThanEnd()
        {
            #region Arrange
            int start = 1;
            int end = 5;

            #endregion

            #region Act
            FizzBuzz fizzBuzz = new FizzBuzz(end, start);

            #endregion

            #region Assert
            Assert.IsNotNull(fizzBuzz);

            #endregion
        }

        [Test]
        public void FizzBuzz_CreateInstanceWhenOnlyEndValueIsGiven()
        {
            #region Arrange
            int end = 5;

            #endregion

            #region Act
            FizzBuzz fizzBuzz = new FizzBuzz(end);

            #endregion

            #region Assert
            Assert.IsNotNull(fizzBuzz);

            #endregion
        }

        [Test]
        public void RunFizzBuzz_ReturnExpectedResult()
        {
            #region Arrange
            int end = 5;
            string expectedResult = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\n";

            #endregion

            #region Act
            FizzBuzz fizzBuzz = new FizzBuzz(end);
            var result = fizzBuzz.RunFizzBuzz();

            #endregion

            #region Assert
            Assert.AreEqual(expectedResult, fizzBuzz.RunFizzBuzz());
            #endregion

        }

        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(16, "16")]
        public void RunFizzBuzz_ReturnExpectedLastResult(int end, string expectedResult)
        {
            #region Arrange

            #endregion

            #region Act
            FizzBuzz fizzBuzz = new FizzBuzz(end);
            var linesArray = fizzBuzz.RunFizzBuzz().Split("\r\n");
            linesArray = linesArray.Take(linesArray.Length - 1).ToArray();
            var result = linesArray.Last();

            #endregion

            #region Assert
            Assert.AreEqual(expectedResult, result);
            #endregion
        }
    }
}