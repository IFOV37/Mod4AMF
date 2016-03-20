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
            numberArray[9] = 107;

            arraySum(numberArray);
            Console.WriteLine(largestVal(numberArray));
            Console.WriteLine(smallestVal(numberArray));

            Console.ReadLine();

        }

        // PQ 1
        private static void arraySum(int[] inputArray)
        {
            int sum = 0;
            foreach (int number in inputArray)
            {
                sum = sum + number;
            }
            Console.WriteLine(sum);

        }

        // PQ 2
        private static int largestVal(int[] inputArray)
        {
            int largeVal = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > largeVal)
                    largeVal = inputArray[i];
            }

            return largeVal;
        }

        private static int smallestVal(int[] inputArray)
        {
            int smallVal = inputArray[0];

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] < smallVal)
                    smallVal = inputArray[i];
            }

            return smallVal;
        }
    }
}
