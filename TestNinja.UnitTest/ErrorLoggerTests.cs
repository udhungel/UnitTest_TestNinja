﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));

        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            //logger.Log(error); this will throw error need a delegate 

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_VAlidError_RaiseErorrLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            //check event is raised before the method fires if so id should have some value
            logger.ErrorLogged += (sender, args) => { id = args;};  
            logger.Log("a");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));

        }

    }
}
