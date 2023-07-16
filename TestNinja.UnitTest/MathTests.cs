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
    }
}
