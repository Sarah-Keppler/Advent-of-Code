using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2025.DayOne
{
    public class SafeDial
    {
        #region Properties

        public int CurrentNumber = 50;

        List<string> _FileContent;
        int _ZeroCounter = 0;

        #endregion

        #region Constructors

        public SafeDial(string fileName) {
            _FileContent = File.ReadAllLines(fileName).ToList();
        }

        #endregion

        #region Methods

        public int ThinkAndFindPassword()
        {
            foreach (string line in _FileContent) {
                if ('L' == line[0])
                {
                    RotateLeft(Int32.Parse(line.Substring(1)));
                } else
                {
                    RotateRight(Int32.Parse(line.Substring(1)));
                }

                if (0 == CurrentNumber)
                {
                    _ZeroCounter++;
                }
            }
            return _ZeroCounter;
        }

        private void RotateLeft(int distance)
        {
            int currentDistance = distance;

            while (CurrentNumber - currentDistance < 0)
            {
                currentDistance -= CurrentNumber;
                CurrentNumber = 100;
            }

            CurrentNumber -= currentDistance;
        }

        private void RotateRight(int distance)
        {
            int currentDistance = distance;

            while (CurrentNumber + currentDistance > 100)
            {
                if (CurrentNumber == 0)
                {
                    currentDistance -= 100;
                } else
                {
                    currentDistance -= 100 - CurrentNumber;
                }
                CurrentNumber = 0;
            }

            CurrentNumber += currentDistance;
            if (100 == CurrentNumber)
            {
                CurrentNumber = 0;
            }
        }

        #endregion
    }
}
