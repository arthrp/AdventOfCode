using NUnit.Framework;

namespace AdventOfCodeTests
{
    public class DayTwoTests
    {
        [Test]
        public void BasicCasesPass()
        {
            var dayTwo = new DayTwo();
            Assert.AreEqual(3500, dayTwo.Solve("1,9,10,3,2,3,11,0,99,30,40,50"));
            Assert.AreEqual(30, dayTwo.Solve("1,1,1,4,99,5,6,0,99"));
            Assert.AreEqual(2, dayTwo.Solve("1,0,0,0,99"));
            Assert.AreEqual(2, dayTwo.Solve("2,3,0,3,99"));
        }
    }
}