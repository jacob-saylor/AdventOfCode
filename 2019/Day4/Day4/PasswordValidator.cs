using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    public static class PasswordValidator
    {
        public static bool MeetsDoubleCritera(int number)
        {
            var numberString = number.ToString();
            for(int i=1; i< numberString.Length; i++)
            {
                if(numberString[i-1] == numberString[i])
                {
                    return true;
                }
            }

            return false;
        }
        
        public static bool NeverDecrease(int number)
        {
            var highestValue = 0;
            var numberString = number.ToString();
            for (int i = 0; i < numberString.Length; i++)
            {
                if (numberString[i] < highestValue)
                {
                    return false;
                }

                if (numberString[i] > highestValue)
                {
                    highestValue = numberString[i];
                }                
            }

            return true;
        }

        public static bool ContainsAtLeastOneDouble(int number)
        {
            var numberString = number.ToString();
            int count = 1;
            for (int i = 1; i < numberString.Length; i++)
            {
                if (numberString[i] == numberString[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count == 2)
                    {
                        return true;
                    }

                    count = 1;
                }
            }

            return count == 2;                     
        }
    }
}
