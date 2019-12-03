using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public static class FuelCalculator
    {
        public static int DetermineFuelRequired(int mass)
        {
            return decimal.ToInt32(Math.Floor(mass / 3M) - 2);
        }

        // ToDo : Negative fuel loop?
    }
}
