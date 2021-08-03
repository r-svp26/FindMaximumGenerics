using FindMaximumGenerics;
using NUnit.Framework;

namespace FindMaximumGenericsTest
{
    public class Tests
    {
        /// <summary>
        /// Test Case 1.1
        /// </summary>
        [Test]
        public void GivenMaxNumberFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int actualValue = Maximum<int>.GetMax<int> (20,15,10);
            Assert.AreEqual(20,actualValue);
        }
        /// <summary>
        /// Test Case 1.2
        /// </summary>
        [Test]
        public void GivenMaxNumberSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int actualValue = Maximum<int>.GetMax<int>(5, 15, 10);
            Assert.AreEqual(15, actualValue);
        }
        /// <summary>
        /// Test Case 1.3
        /// </summary>
        [Test]
        public void GivenMaxNumberThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            int actualValue = Maximum<int>.GetMax<int>(5, 15, 30);
            Assert.AreEqual(30, actualValue);
        }
        /// <summary>
        /// Test Case 2.1
        /// </summary>
        [Test]
        public void GivenMaxNumberFloatFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float actualValue = Maximum<float>.GetMax<float>(20f, 15f, 10f);
            Assert.AreEqual(20f, actualValue);
        }
        /// <summary>
        /// Test Case 2.2
        /// </summary>
        [Test]
        public void GivenMaxNumberFloatSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float actualValue = Maximum<float>.GetMax<float>(5f, 15f, 10f);
            Assert.AreEqual(15f, actualValue);
        }
        /// <summary>
        /// Test Case 2.3
        /// </summary>
        [Test]
        public void GivenMaxNumberFloatThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            float actualValue = Maximum<float>.GetMax<float>(5f, 15f, 25f);
            Assert.AreEqual(25f, actualValue);
        }
        /// <summary>
        /// Test Case 3.1
        /// </summary>
        [Test]
        public void GivenMaxStringFirstPosition_WhenMaxTest_ShouldReturnTrue()
        {
            string actualValue = Maximum<string>.GetMax<string>("C", "A", "B");
            Assert.AreEqual("C", actualValue);
        }
        /// <summary>
        /// Test Case 3.2
        /// </summary>
        [Test]
        public void GivenMaxStringSecondPosition_WhenMaxTest_ShouldReturnTrue()
        {
            string actualValue = Maximum<string>.GetMax<string>("A", "C", "B");
            Assert.AreEqual("C", actualValue);
        }
        /// <summary>
        /// Test Case 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringThirdPosition_WhenMaxTest_ShouldReturnTrue()
        {
            string actualValue = Maximum<string>.GetMax<string>("A", "B", "C");
            Assert.AreEqual("C", actualValue);
        }
    }
}