using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputSize = double.Parse(Console.ReadLine());
            string parameterInput = Console.ReadLine();
            double result = 0;
            if (parameterInput.Equals("area"))// surfaceArea
                result = 6 * (Math.Pow(inputSize, 2));
                
            else if (parameterInput.Equals("space"))//Space Diagonals
                result = Math.Sqrt(3 * (Math.Pow(inputSize, 2)));

            else if (parameterInput.Equals("face"))//Face Diagonals
                result = Math.Sqrt(2 * (Math.Pow(inputSize,2)));

            else if (parameterInput.Equals("volume"))//volume
                result = Math.Pow(inputSize, 3);

            Console.WriteLine("{0:f2}", result);
        }


    }
}
