using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using SwinAdventure;
namespace IdentifiableObjectTests
{
    public class Tests
    {
        private IdentifiableObject testobject;

        [SetUp]
        public void Setup()
        {
            testobject = new IdentifiableObject(new string[] { "fred", "bob" });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(testobject.AreYou("fred"));
            Assert.IsTrue(testobject.AreYou("bob"));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(testobject.AreYou("wilma"));
            Assert.IsFalse(testobject.AreYou("boby"));
        }

        [Test]
        public void TestCaseSensitive()
        {
            Assert.IsTrue(testobject.AreYou("FRED"));
            Assert.IsTrue(testobject.AreYou("bOB"));
        }

        [Test]
        public void TestFirstID()
        {
            Assert.AreEqual("fred", testobject.FirstId);
        }

        [Test]
        public void TestAddID()
        {
            testobject.AddIdentifier("wilma");
            Assert.IsTrue(testobject.AreYou("wilma"));
        }
    }
}