using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public static class FuelCalculator
    {
        public static int DetermineFuelRequired(int mass)
        {
            var fuel = decimal.ToInt32(Math.Floor(mass / 3M) - 2);
            return fuel > 0 ? fuel : 0;
        }

        public static int DetermineFuelTotal(int mass, int total = 0)
        {
            if (mass <= 0)
            {
                return total;
            }

            var fuel = DetermineFuelRequired(mass);
            return DetermineFuelTotal(fuel, total + fuel);
        }
    }
}
