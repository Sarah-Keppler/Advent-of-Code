using AOC_2025.DayThree;

namespace AOC_2025_Test
{
    [TestClass]
    public sealed class BankOptimizerTest
    {
        [TestMethod]
        public async Task GetLargestNumberInString()
        {
            string bank = "987654321111111";
            BankOptimizer bankOptimizer = new();

            int largestJoltage = bankOptimizer.GetLargestJoltagePossible(bank);

            Assert.AreEqual(98, largestJoltage);
        }

        [TestMethod]
        public async Task GetLargestNumberInStringWhenTheyAreNotOrdered()
        {
            string bank = "811111111111119";
            BankOptimizer bankOptimizer = new();

            int largestJoltage = bankOptimizer.GetLargestJoltagePossible(bank);

            Assert.AreEqual(89, largestJoltage);
        }

        [TestMethod]
        public async Task GetLargestNumberInStringWhenTheyAreNotTHeBiggestNumbers()
        {
            string bank = "818181911112111";
            BankOptimizer bankOptimizer = new();

            int largestJoltage = bankOptimizer.GetLargestJoltagePossible(bank);

            Assert.AreEqual(92, largestJoltage);
        }
    }
}
