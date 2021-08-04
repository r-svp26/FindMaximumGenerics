using FindMaximumGenerics;
using NUnit.Framework;

namespace FindMaximumGenericsTest
{
    public class Tests
    {
        /// <summary>
        /// Test Case 4.1
        /// </summary>
        [Test]
        public void GivenMaxNumberWhenMaxTest_ShouldReturnTrue()
        {
            int[] array = {20, 12, 10, 5};
            int actualValue = new Maximum<int>(array).GetMax();
            Assert.AreEqual(20,actualValue);
        }
        /// <summary>
        /// Test Case 4.2
        /// </summary>
        [Test]
        public void GivenMaxFloatWhenMaxTest_ShouldReturnTrue()
        {
            float[] array = {12f, 20f, 25f, 5f};
            float actualValue = new Maximum<float>(array).GetMax();
            Assert.AreEqual(25f, actualValue);
        }
        /// <summary>
        /// Test Case 4.3
        /// </summary>
        [Test]
        public void GivenMaxStringWhenMaxTest_ShouldReturnTrue()
        {
            string[] array = {"A", "C", "D", "C"};
            string actualValue = new Maximum<string>(array).GetMax();
            Assert.AreEqual("D", actualValue);
        }
    }
}