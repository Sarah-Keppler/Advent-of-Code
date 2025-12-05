namespace AOC_2025.DayTwo
{
    public sealed class DayTwo
    {
        #region Properties

        List<string> _IdList;

        #endregion

        #region Constructors

        public DayTwo(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            _IdList = [.. lines[0].Split(',')];
        }

        #endregion

        #region Methods

        public List<string> GetInvalidIds()
        {
            List<string> invalidIds = new List<string>();
            foreach (var id in _IdList)
            {
                if (isLeadingZerosIds(id) || hasDoubleDigitsSequence(id))
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
            int idLength = id.Count();
            char lastChar = id[0];

            for(int i = 1; i < idLength; ++i)
            {
                if (lastChar == id[i])
                {
                    return true;
                }
                lastChar = id[i];
            }

            return false;
        }

        #endregion
    }
}