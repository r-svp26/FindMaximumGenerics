using System;

namespace FindMaximumGenerics
{
    class Program
    {
        /// <summary>
        /// execution start from here!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int intValue = Maximum<int>.GetMax(10,20,30);
            Console.WriteLine("Max value among these three integer:" +intValue);
            float floatValue = Maximum<double>.GetMax(10.2f, 35.1f, 30.5f);
            Console.WriteLine("Max value among these three floats:" +floatValue);
            string stringValue = Maximum<string>.GetMax("Apple", "Peach", "Banana");
            Console.WriteLine("Max value among these three string:" +stringValue);
        }
    }
}
