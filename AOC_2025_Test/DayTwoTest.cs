using AOC_2025.DayTwo;

namespace AOC_2025_Test
{
    [TestClass]
    public sealed class DayTwoTest
    {
        [TestMethod]
        public void SumAllInvalidIds()
        {
            DayTwo dayTwo = new DayTwo("DayTwoTest.txt");
            Int128 expectedSum = 1227775554;

            Int128 sum = dayTwo.SumAllInvalidsIds();

            Assert.AreEqual(expectedSum, sum, $"Someone is bad at math: {sum}");
        }
    }
}
