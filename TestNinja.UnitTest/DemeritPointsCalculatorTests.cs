using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private Fundamentals.DemeritPointsCalculator _demeritPointsCalculator;
        //Setup
        //TearDown

        [SetUp]
        public void Setup()
        {
            _demeritPointsCalculator = new Fundamentals.DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void Calculate_SpeedOutOfRange_ReturnsOutOfRangeException(int speed)
        {
           // var result = _demeritPointsCalculator.CalculateDemeritPoints(speed); this throws exception need a delegate
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }


        

        [Test]
        [TestCase(0,0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]       
        public void Calculate_WhenCall_ReturnsDemeritPoints(int speed, int expectedResult)
        {
            var pointsPerSpeed = _demeritPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(pointsPerSpeed, Is.EqualTo(expectedResult));
        }     

    }
}
