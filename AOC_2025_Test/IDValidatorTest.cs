using AOC_2025.DayTwo;

namespace AOC_2025_Test
{
    [TestClass]
    public sealed class IDValidatorTest
    {
        [TestMethod]
        public async Task ReturnLeadingZerosIds()
        {
            string tempFile = Path.GetTempFileName(); 
            var idList = new List<string> {"0101-101", "101-0110"};
            await File.WriteAllTextAsync(tempFile, string.Join(',', idList));
            IDValidator iDValidator = new IDValidator(tempFile);
            List<string> expectedInvalidIds = new List<string> { "0101", "0110" };

            List<string> invalidIds = iDValidator.GetInvalidIds();

            CollectionAssert.AreEquivalent(expectedInvalidIds, invalidIds, $"Not all leading zeros are present: {string.Join(',', invalidIds)}");
        }

        [TestMethod]
        public void ReturnIdsWithDoubleDigitsSequence()
        {
            IDValidator iDValidator = new IDValidator("DayTwoTest.txt");
            List<string> expectedInvalidIds = new List<string> { "11", "22", "99", "1010", "1188511885", "222222", "446446", "38593859" };

            List<string> invalidIds = iDValidator.GetInvalidIds();

            CollectionAssert.AreEquivalent(expectedInvalidIds, invalidIds, $"Not all ids with double digits sequence are present: {string.Join(',', invalidIds)}");
        }

        [TestMethod]
        public void ReturnIdsWithDoubleDigitsSequenceWithSillyElfRules()
        {
            IDValidator iDValidator = new IDValidator("DayTwoTest.txt", true);
            List<string> expectedInvalidIds = new List<string> { "11", "22", "99", "111", "999", "1010", "1188511885", "222222", "446446", "38593859", "565656", "824824824", "2121212121" };

            List<string> invalidIds = iDValidator.GetInvalidIds();

            CollectionAssert.AreEquivalent(expectedInvalidIds, invalidIds, $"Not all ids with double digits sequence are present: {string.Join(',', invalidIds)}");
        }
    }
}
