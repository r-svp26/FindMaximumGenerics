using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumGenerics
{
    class Maximum
    {
        /// <summary>
        /// get max value of string character.
        /// </summary>
        /// <param name="firstWord"></param>
        /// <param name="secondWord"></param>
        /// <param name="thirdWord"></param>
        public static void GetMax(string firstWord, string secondWord, string thirdWord)
        {
            //// used compareto method
            if (firstWord.CompareTo(secondWord) > 0 && firstWord.CompareTo(thirdWord) > 0)
                Console.WriteLine(firstWord + ", Is the max string.");
            if (secondWord.CompareTo(firstWord) > 0 && secondWord.CompareTo(thirdWord) > 0)
                Console.WriteLine(secondWord + ", Is the max string.");
            if (thirdWord.CompareTo(firstWord) > 0 && thirdWord.CompareTo(secondWord) > 0)
                Console.WriteLine(thirdWord + ", Is the max string.");
        }
    }
}
