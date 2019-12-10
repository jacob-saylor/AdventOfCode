using System;
using System.Diagnostics;

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
                for(int i=0; i <= 99; i++)
                {
                    for(int j = 0; j<99; j++)
                    {
                        Debug.WriteLine(IntcodeProgram.ProcessProgramString(line, i, j));
                    }
                }                
            }
            file.Close();
        }
    }
}
