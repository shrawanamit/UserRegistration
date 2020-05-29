using NUnit.Framework;
using userRagistration;
using System;

namespace NUnitTestUser
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void givenFirstName_WhenProper_ReturnTrue()
        {
            UserValidater validater = new UserValidater();
            Boolean result = validater.validateFirstName("Amit");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void givenLasttName_WhenProper_ReturnTrue()
        {
            UserValidater validater = new UserValidater();
            Boolean result = validater.validateLastName("Kumar");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void givenEmail_WhenProper_ReturnTrue()
        {
            UserValidater validater = new UserValidater();
            Boolean result = validater.validateEmailId("amitkumar06111@gmail.com");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void givenMobileNo_WhenProper_ShouldReturnTrue()
        {
            UserValidater validater = new UserValidater();
            Boolean result = validater.validateMobileNo("91 8390202340");
            Assert.AreEqual(true, result);
        }

    }
}