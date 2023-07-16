using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_SumofArguments()
        {
            //Arrange
            //Add
            //Assert
            Fundamentals.Math mathTest = new Fundamentals.Math();

            var result = mathTest.Add(1, 2);

            Assert.AreEqual(3, result);
        }
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            Fundamentals.Math mathTest = new Fundamentals.Math();

            var result = mathTest.Max(2, 1);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            Fundamentals.Math mathTest = new Fundamentals.Math();

            var result = mathTest.Max(1, 2);

            Assert.AreEqual(2, result);

        }

        [Test]
        public void Max_ArgumentAreEqual_ReturnTheSameArgument()
        {
            Fundamentals.Math mathTest = new Fundamentals.Math();

            var result = mathTest.Max(1, 1);

            Assert.AreEqual(1, result);
        }
    }
}
