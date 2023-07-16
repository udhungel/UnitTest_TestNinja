using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;
        //Setup
        //TearDown

        [SetUp]
        public void Setup() 
        {
            _math = new Fundamentals.Math(); 
        }
        [Test]
        [Ignore("Because I want to")]
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
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]

        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            //Arrange
            //Add
            //Assert            
            var result = _math.Max(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumberUotoLimit()
        {
            var result = _math.GetOddNumbers(5);

            ////assertion logic, how did i get to line 58 logic
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);


        }
    }
}
