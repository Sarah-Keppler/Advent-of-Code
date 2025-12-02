using AOC_2025.DayOne;

namespace AOC_2025_Test
{
    [TestClass]
    public sealed class SafeDialTest
    {
        [TestMethod]
        public async Task ThinkAndGetSecuredPassword()
        {
            SafeDial safeDial = new SafeDial("DayOneTest.txt");
            
            int password = safeDial.ThinkAndFindPassword();

            Assert.IsTrue(3 == password, $"Did not think hard enough: {password}");
        }

        [TestMethod]
        public async Task RotateLeft()
        {
            string tempFile = Path.GetTempFileName();
            var lines = new[] { "L10" };
            await File.WriteAllLinesAsync(tempFile, lines);
            SafeDial safeDial = new SafeDial(tempFile);
            safeDial.CurrentNumber = 5;
            
            safeDial.ThinkAndFindPassword();

            Assert.IsTrue(95 == safeDial.CurrentNumber, $"Was not left enough: {safeDial.CurrentNumber}");
        }

        [TestMethod]
        public async Task DoubleRotateLeft()
        {
            string tempFile = Path.GetTempFileName();
            var lines = new[] { "L210" };
            await File.WriteAllLinesAsync(tempFile, lines);
            SafeDial safeDial = new SafeDial(tempFile);
            
            safeDial.ThinkAndFindPassword();

            Assert.IsTrue(40 == safeDial.CurrentNumber, $"Was not left enough: {safeDial.CurrentNumber}");
        }

        [TestMethod]
        public async Task RotateRight()
        {
            string tempFile = Path.GetTempFileName();
            var lines = new[] { "R10" };
            await File.WriteAllLinesAsync(tempFile, lines);
            SafeDial safeDial = new SafeDial(tempFile);
            safeDial.CurrentNumber = 95;
            
            safeDial.ThinkAndFindPassword();

            Assert.IsTrue(5 == safeDial.CurrentNumber, $"Was not right enough: {safeDial.CurrentNumber}");
        }

        [TestMethod]
        public async Task DoubleRotateRight()
        {
            string tempFile = Path.GetTempFileName();
            var lines = new[] { "R210" };
            await File.WriteAllLinesAsync(tempFile, lines);
            SafeDial safeDial = new SafeDial(tempFile);
            
            safeDial.ThinkAndFindPassword();

            Assert.IsTrue(60 == safeDial.CurrentNumber, $"Was not right enough: {safeDial.CurrentNumber}");
        }
    }
}
