using System;
using System.Collections;

namespace LottoPicks
{
    /// <summary>
    /// LottoPicks Example, source code file Urn.cs
    /// LottoPicks Example, Urn.cs source code
    /// Simulate drawing balls from an urn (jar) without replacement.
    /// Use an ArrayList collection to keep track of the balls.
    /// </summary>

    public class Urn
    {
        // Private instance variables.
        private ArrayList balls;
        private int _totalBalls;
        private Random r = new Random();

        // Parameterized constructor.
        public Urn(int initialNumBalls)
        {
;
            // _totalBalls must be nonnegative.
            if (initialNumBalls > 0)
            {
                _totalBalls = initialNumBalls;
            }
            else
            {
                _totalBalls = 0;
            }

            // Initialize collection of balls.
            balls = new ArrayList();
            for (int i = 1; i <= _totalBalls; i++)
            {
                balls.Add(i);
            }
        }

        // Public read-only method.
        public int TotalBalls
        {
            get { return _totalBalls; }
        }

        // Public methods:

        // Return number of balls remaining.
        public int BallsRemaining()
        {
            return balls.Count;
        }

        // Return true count of balls is zero.
        public bool IsEmpty
        {
            get { return balls.Count == 0; }
        }

        // Draw a ball from urn.
        public int Draw()
        {
            int n = r.Next(0, balls.Count);
            int ball = (int)balls[n];
            balls.RemoveAt(n);
            return ball;
        }

        // Print remaining balls in urn.
        public override string ToString()
        {
            string s = "";
            foreach (int i in balls)
            {
                s += i.ToString() + " ";
            }
            return s;
        }
    }
}