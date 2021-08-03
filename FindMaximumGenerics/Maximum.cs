using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumGenerics
{
    public class Maximum<T> where T:IComparable
    {
        /// <summary>
        /// get max value using generics method.
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="thirdValue"></param>
        public static T GetMax<T>(T firstValue, T secondValue, T thirdValue) where T : System.IComparable<T>
        {
            //// used compareto method
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                return thirdValue;
            throw new Exception("Three values are equals");
        }
    }
}
