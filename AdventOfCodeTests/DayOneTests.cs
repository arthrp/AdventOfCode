using NUnit.Framework;

namespace AdventOfCodeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicCasesPass()
        {
            var dayOne = new DayOne();
            Assert.AreEqual(dayOne.Solve("12"), 2m);
            Assert.AreEqual(dayOne.Solve("14"), 2m);
            Assert.AreEqual(dayOne.Solve("1969"), 654m);
        }
    }
}