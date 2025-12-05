namespace AOC_2025.DayTwo
{
    public sealed class IDValidator
    {
        #region Properties

        List<string> _IdList;

        #endregion

        #region Constructors

        public IDValidator(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            _IdList = [.. lines[0].Split([',', '-'])];
        }

        #endregion

        #region Methods

        public List<string> GetInvalidIds()
        {
            List<string> invalidIds = new List<string>();
            foreach (var id in _IdList)
            {
                if (isLeadingZerosIds(id))
                {
                    invalidIds.Add(id);
                }
            }
            return invalidIds;
        }

        private bool isLeadingZerosIds(string id)
        {
            return '0' == id[0];
        }

        private bool hasDoubleDigitsSequence(string id)
        {
            string sequence = "";

            foreach (var c in id)
            {
                if (sequence[^1] == c)
                {

                }
            }
        }

        #endregion
    }
}