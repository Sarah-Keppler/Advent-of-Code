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
        bool _PartTwo = false;

        #endregion

        #region Constructors

        public SafeDial(string fileName, bool partTwo = false)
        {
            _FileContent = File.ReadAllLines(fileName).ToList();
            _PartTwo = partTwo;
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
                if (_PartTwo && CurrentNumber != 0)
                {
                    _ZeroCounter++;
                }
                currentDistance -= CurrentNumber;
                CurrentNumber = 100;
            }

            CurrentNumber -= currentDistance;
            if (100 == CurrentNumber)
            {
                CurrentNumber = 0;
            }
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


                if (_PartTwo)
                {
                    _ZeroCounter++;
                }
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
