using NUnit.Framework;

namespace TestLibrary.Tests
{
    [TestFixture]
    public class TestClass
    {
        ClassUnderTest c = new ClassUnderTest();

        [Test]
        public void TestMethod()
        {
            Assert.AreSame("Jeff", c.TestMethod("Jeff"));
        }
    }
}
