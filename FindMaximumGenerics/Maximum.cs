using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumGenerics
{
    class Maximum
    {
        /// <summary>
        /// get max value of floats numbers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        public static void GetMax(float firstNumber, float secondNumber, float thirdNumber)
        {
            //// used compareto method
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine(firstNumber+", Is the max value.");
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine(secondNumber + ", Is the max value.");
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                Console.WriteLine(thirdNumber + ", Is the max value.");
        }
    }
}
