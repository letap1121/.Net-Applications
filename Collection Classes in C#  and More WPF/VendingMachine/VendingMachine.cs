using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExample
{
    /// <summary>          
    /// Simulate a candy bar vending machine that starts with
    /// 5 candy bars, where each candy bar costs 3 quarters.
    /// </summary>

    public class VendingMachine
    {
        // private instance variables
        private int _numQuarters, _numCandyBars;

        // Public noarg constructor
        public VendingMachine()
        {
            // Set the candy bar cost in quarters.  
            _numQuarters = 3;

            // Set initial number of candy bars.
            _numCandyBars = 5;
        }

        // Public read only properties:

        public int NumQuarters
        {
            get { return _numQuarters; }
        }

        public int NumCandyBars
        {
            get { return _numCandyBars; }
        }

        // Public methods:

        public string DepositQuarter()
        {
            _numQuarters++;
            return "Quarter deposited.";
        }

        public string SelectCandy()
        {
            if (_numQuarters >= 3 && _numCandyBars > 0)
            {
                _numQuarters = _numQuarters -3;
                _numCandyBars--;
                return "Candy bar dispensed";
            }
            else if (_numCandyBars > 0)
            {
                return "Not enough quarters to buy candy bar.";
            }
            else
            {
                return "No candy bars in machine.";
            }
        }

        public override string ToString()
        {

            return "Total Quarters: " + _numQuarters + " Total Bars:" + _numCandyBars;
        }
    }

}
