﻿using System;
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
            numberArray[0] = 3;
            numberArray[1] = 4;
            numberArray[2] = 7;
            numberArray[3] = 1;
            numberArray[4] = 9;
            numberArray[5] = 2;
            numberArray[6] = 6;
            numberArray[7] = 10;
            numberArray[8] = 12;
            numberArray[9] = 14;

            arraySum(numberArray);
            Console.WriteLine(largestVal(numberArray));
            Console.WriteLine(smallestVal(numberArray));

            numberArray = squaredArray(numberArray);
            foreach (int number in numberArray)
            {
                Console.WriteLine(number);
            }
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

        // PQ 3
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

        // PQ 4
        private static int[] squaredArray(int[] inputArray)
        {

            for (int i = 0; i < inputArray.Length; i++)
			{
			    inputArray[i] = inputArray[i] * inputArray[i];
			}

            return inputArray;
        }
    }
}
