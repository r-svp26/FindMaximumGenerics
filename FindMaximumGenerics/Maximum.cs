using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumGenerics
{
    public class Maximum<T> where T : IComparable
    {
        public T[] array;
        public Maximum(T[] array)
        {
            this.array = array;
        }
        public T[] SortArray(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T MaxValue(T[] value)
        {
            T[] sortedValue = SortArray(value);
            return sortedValue[sortedValue.Length - 1];
        }
        public T GetMax()
        {
            T max = MaxValue(this.array);
            return max;
        }
    }
}
