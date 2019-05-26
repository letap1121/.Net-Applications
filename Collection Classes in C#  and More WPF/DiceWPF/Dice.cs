using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWPF
{
    public class Dice
    {
        // private instance variables.
        private int _face1, _face2;
        private Random r = new Random();

        // Noarg constructor
        // Newly created die object has a random value
        public Dice()
        {
            Roll();
        }

       

        // Read only properties
        public int Face1
        {
            get { return _face1; }
        }

        public int Face2
        {
            get { return _face2; }
        }

        // Public method
        public void Roll()
        {
            _face1 = r.Next(1, 7);
            _face2 = r.Next(1, 7);
        }
    }
}
