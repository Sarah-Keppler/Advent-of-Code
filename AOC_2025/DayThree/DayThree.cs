namespace AOC_2025.DayThree
{
    public sealed class DayThree
    {
        #region Properties

        string _FileName;

        #endregion

        #region Constructors

        public DayThree(string fileName)
        {
            _FileName = fileName;
        }

        #endregion

        #region Methods

        public string GetTotalOutputJoltage()
        {
            BankOptimizer bankOptimizer = new();
            var lines = File.ReadAllLines(_FileName);
            int sum = 0;
            
            foreach(string line in lines)
            {
                sum += bankOptimizer.GetLargestJoltagePossible(line);
            }

            return sum.ToString();
        }

        #endregion
    }
}