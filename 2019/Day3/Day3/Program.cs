using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>();

            string line = string.Empty;
            System.IO.StreamReader file = new System.IO.StreamReader(@"input.txt");
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            Console.WriteLine(WireCalculation.DetermineManhattanDistance(lines[0], lines[1]));
            file.Close();
            Console.ReadLine();
        }
    }
}
