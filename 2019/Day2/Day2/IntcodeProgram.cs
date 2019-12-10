using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    public static class IntcodeProgram
    {        
        public static string ProcessProgramString(string codes)
        {
            var program = codes.Split(',').Select(Int32.Parse).ToList();
                        
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
