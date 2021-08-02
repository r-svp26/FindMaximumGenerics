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
            Console.WriteLine("Max value among these three integer");
            Maximum<int>.GetMax(10,20,30);
            Console.WriteLine("Max value among these three floats");
            Maximum<double>.GetMax(10.2f, 35.1f, 30.5f);
            Console.WriteLine("Max value among these three string");
            Maximum<string>.GetMax("Apple", "Peach", "Banana");
        }
    }
}
