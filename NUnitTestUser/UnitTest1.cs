using NUnit.Framework;
using userRagistration;

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
            bool result = validater.validateFirstName("Amit");
            Assert.AreEqual(true, result);
        }
    }
}