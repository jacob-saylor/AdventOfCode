using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            System.IO.StreamReader file = new System.IO.StreamReader(@"input.txt");
            while ((line = file.ReadLine()) != null)
            {
                // ToDo: Load the programs in
            }
            file.Close();
        }
    }
}
