using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4AMF
{
    class Program
    {
        static void Main(string[] args)
        {
            // PQ 1

            int[] numberArray = new int[10];
            numberArray[0] = 44;
            numberArray[1] = 27;
            numberArray[2] = 34;
            numberArray[3] = 37;
            numberArray[4] = 22;
            numberArray[5] = 11;
            numberArray[6] = 15;
            numberArray[7] = 14;
            numberArray[8] = 96;
            numberArray[9] = 82;

            arraySum(numberArray);

            Console.ReadLine();

        }

        private static void arraySum(int[] inputArray)
        {
            int sum = 0;
            foreach (int number in inputArray)
            {
                sum = sum + number;
            }
            Console.WriteLine(sum);

        }
    }
}
