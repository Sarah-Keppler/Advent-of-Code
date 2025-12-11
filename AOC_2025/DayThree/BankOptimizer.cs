namespace AOC_2025.DayThree
{
    public sealed class BankOptimizer
    {
        #region Constructors

        public BankOptimizer() {}

        #endregion

        #region Methods

        public int GetLargestJoltagePossible(string bank)
        {
            int biggestNumber = 0;
            int biggestNumberIndex = 0;

            for (int i = 0; i < bank.Length; ++i)
            {
                int charAsInt = bank[i] - '0';
                
                if (biggestNumber < charAsInt)
                {
                    biggestNumber = charAsInt;
                    biggestNumberIndex = i;
                }
            }

            if (biggestNumberIndex == bank.Length - 1)
            {
                int secondBiggestNumber = GetSecondbiggestNumber(bank, 0, biggestNumberIndex);
                string largestJoltageAsString = secondBiggestNumber.ToString() + biggestNumber.ToString();
                return int.Parse(largestJoltageAsString);
            } else
            {
                int secondBiggestNumber = GetSecondbiggestNumber(bank, biggestNumberIndex, biggestNumberIndex);
                string largestJoltageAsString = biggestNumber.ToString() + secondBiggestNumber.ToString();
                return int.Parse(largestJoltageAsString);
            }
        }

        private int GetSecondbiggestNumber(string bank, int startIndex, int firstbiggestNumberIndex)
        {
            int biggestNumber = 0;

            for (int i = startIndex; i < bank.Length; ++i)
            {
                int charAsInt = bank[i] - '0';
                
                if (biggestNumber < charAsInt && i != firstbiggestNumberIndex)
                {
                    biggestNumber = charAsInt;
                }
            }

            return biggestNumber;
        }

        #endregion
    }
}