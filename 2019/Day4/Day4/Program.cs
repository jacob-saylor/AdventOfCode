using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeterminePossiblePasswordCount(245318,765747));
            Console.ReadLine();
        }

        static int DeterminePossiblePasswordCount(int start, int end)
        {
            int possiblePassword = 0;
            for(int i = start; i<= end; i++)
            {
                if(PasswordValidator.MeetsDoubleCritera(i) && PasswordValidator.NeverDecrease(i) && PasswordValidator.ContainsAtLeastOneDouble(i))
                {
                    possiblePassword++;
                }
            }

            return possiblePassword; // 912 is too high // 548 is too low
        }
    }
}
