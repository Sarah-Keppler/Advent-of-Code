namespace AOC_2025.DayTwo
{
    public sealed class DayTwo
    {
        #region Properties

        string _FileName;

        #endregion

        #region Constructors

        public DayTwo(string fileName)
        {
            _FileName = fileName;
        }

        #endregion

        #region Methods

        public Int128 SumAllInvalidsIds(bool sillyElfRulesOn = false)
        {
            IDValidator iDValidator = new IDValidator(_FileName, sillyElfRulesOn);
            List<string> invalidIds = iDValidator.GetInvalidIds();
            Int128 sum = 0;

            foreach (string invalidId in invalidIds)
            {
                sum += Int128.Parse(invalidId);
            }

            return sum;
        }

        #endregion
    }
}