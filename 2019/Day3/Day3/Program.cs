using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            System.IO.StreamReader file = new System.IO.StreamReader(@"input.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine("Hit");
                // ToDo : "Draw" the wire
            }

            file.Close();

            Console.ReadLine();
        }
    }
}
