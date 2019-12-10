using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    public static class IntcodeProgram
    {        
        public static string ProcessProgramString(string codes, int noun = 0, int verb = 0)
        {
            var program = codes.Split(',').Select(Int32.Parse).ToList();

            if(noun != 0 && verb != 0)
            {
                program[1] = noun;
                program[2] = verb;
            }            

            int counter = 0;
            while(counter <= program.Count)
            {
                if (program[counter] == 99) break;

                var opCode = (OperationCode)program[counter];
                var firstInput = program[counter + 1];
                var secondInput = program[counter + 2];
                var outputLocation = program[counter + 3];

                var result = PerformOperation(opCode, program[firstInput], program[secondInput]);
                program[outputLocation] = result;

                counter += 4;
            }

            if(program[0] == 19690720)
            {
                Console.WriteLine($"Noun {noun}");
                Console.WriteLine($"Verb {verb}");
            }            

            return string.Join<int>(",", program);
        }       
        
        private static int PerformOperation(OperationCode opCode, int firstValue, int secondValue)
        {
            if(opCode == OperationCode.Add)
            {
                return firstValue + secondValue;
            }

            return firstValue * secondValue;
        }
    }

    public enum OperationCode
    {
        Add = 1,
        Multiply = 2
    }
}
