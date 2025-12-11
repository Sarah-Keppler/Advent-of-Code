using AOC_2025.DayThree;

namespace AOC_2025_Test
{
    [TestClass]
    public sealed class DayThreeTest
    {
        [TestMethod]
        public void GetTotalOutputJoltage()
        {
            DayThree dayThree = new("DayThreeTest.txt");
            int expectedSum = 357;

            string result = dayThree.GetTotalOutputJoltage();

            Assert.AreEqual(expectedSum, int.Parse(result), $"Someone is bad at math: {result}");
        }
    }
}
