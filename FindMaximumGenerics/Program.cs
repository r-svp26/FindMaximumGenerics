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
            int[] arrayInt = { 20, 12, 10, 5 };
            int actualInt = new Maximum<int>(arrayInt).GetMax();
            Console.WriteLine("Max value of integers:" + actualInt);
            float[] arrayFloat = { 25f, 12f, 10f, 5f};
            float actualFloat = new Maximum<float>(arrayFloat).GetMax();
            Console.WriteLine("Max value of floats:" + actualFloat);
            string[] arrayString = { "A", "C", "D", "C" };
            string actualString = new Maximum<string>(arrayString).GetMax();
            Console.WriteLine("Max value of string:" + actualString);
        }
    }
}
