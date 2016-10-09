using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            while (!inputString.Equals("END"))
            {
                string[] inputArr = inputString.Split(' ');

                long result = 0;
                switch (inputArr[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(inputArr[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(inputArr[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(inputArr[1]);
                            long operandTwo = long.Parse(inputArr[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(inputArr[1]);
                            long operandTwo = long.Parse(inputArr[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                }

                Console.WriteLine(result);
                inputString = Console.ReadLine();
            }
        }
    }
}
