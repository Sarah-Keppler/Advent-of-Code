using System.Globalization;
using System.Text;
using System.Xml;

namespace AOC_2025.DayTwo
{
    public sealed class IDValidator
    {
        #region Properties

        List<string> _IdList;
        bool _SillyElfRulesOn = false;

        #endregion

        #region Constructors

        public IDValidator(string fileName, bool sillyElfRulesOn = false)
        {
            var lines = File.ReadAllLines(fileName);
            _IdList = [.. lines[0].Split(',')];
            _SillyElfRulesOn = sillyElfRulesOn;
        }

        #endregion

        #region Methods

        public List<string> GetInvalidIds()
        {
            List<string> invalidIds = new List<string>();
            foreach (var id in _IdList)
            {
                invalidIds = invalidIds.Concat(GetLeadingZerosIds(id)).ToList();

                invalidIds = _SillyElfRulesOn ? invalidIds.Concat(GetDoubleDigitsSequenceIdsWithSillyElfRules(id)).ToList() : 
                    invalidIds.Concat(GetDoubleDigitsSequenceIds(id)).ToList();
            }
            return invalidIds;
        }

        private List<string> GetLeadingZerosIds(string id)
        {
            List<string> parts = [.. id.Split('-')];
            List<string> invalidIds = new List<string>();

            if ('0' == parts[0][0])
            {
                invalidIds.Add(parts[0]);
            }

            if ('0' == parts[1][0])
            {
                invalidIds.Add(parts[1]);
            }

            return invalidIds;
        }

        private List<string> GetDoubleDigitsSequenceIds(string idRange)
        {
            (Int128 minRange, Int128 maxRange) = getMinAndMaxRange(idRange);
            List<string> invalidIds = new List<string>();

            for(Int128 i = minRange; i <= maxRange; ++i)
            {
                string id = i.ToString();
        
                if (id.Length % 2 != 0)
                {
                    continue;
                }

                int middle = id.Length / 2;
                string partOne = id.Substring(0, middle);
                string partTwo = id.Substring(middle);
                if (partOne.CompareTo(partTwo) == 0)
                {
                    invalidIds.Add(id);
                }
            }

            return invalidIds;
        }

        private List<string> GetDoubleDigitsSequenceIdsWithSillyElfRules(string idRange)
        {
            (Int128 minRange, Int128 maxRange) = getMinAndMaxRange(idRange);
            List<string> invalidIds = new List<string>();

            for (Int128 i = minRange; i <= maxRange; ++i)
            {
                string id = i.ToString();
                StringBuilder pattern = new StringBuilder(id[0].ToString());
                int analyseIndex = 1;
                bool patternMatching = false;

                while (analyseIndex < id.Length)
                {
                    StringBuilder nextPart = new StringBuilder();

                    if (analyseIndex + pattern.Length > id.Length)
                    {
                        nextPart.Append(id.Substring(analyseIndex));
                    } else
                    {
                        nextPart.Append(id.Substring(analyseIndex, pattern.Length));
                    }

                    if (nextPart.ToString().CompareTo(pattern.ToString()) == 0)
                    {
                        patternMatching = true;
                        analyseIndex += nextPart.Length;
                    }
                    else
                    {
                        patternMatching = false;
                        analyseIndex = pattern.Length;
                        pattern.Append(id[analyseIndex]);
                        ++analyseIndex;
                    }
                }

                if (patternMatching)
                {
                    invalidIds.Add(id);
                }
            }

            return invalidIds;
        }

        private (Int128, Int128) getMinAndMaxRange(string id)
        {
            int indexOfDelimiter = id.IndexOf('-');
            
            return (Int128.Parse(id.Substring(0, indexOfDelimiter)), Int128.Parse(id.Substring(indexOfDelimiter + 1)));
        }

        #endregion
    }
}