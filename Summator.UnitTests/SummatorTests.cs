using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_Three_Positive_Numbers() { 
            var nums = new[] { 1, 2, 3 };
            var actual = Summator.Sum(nums);
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Two_Negative_Numbers()
        {
            var nums = new[] { -1, -80 };
            var actual = Summator.Sum(nums);
            var expected = -81;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Negative_And_Positive_Number()
        {
            var nums = new[] { -1, 100 };
            var actual = Summator.Sum(nums);
            var expected = 99;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Zero_And_Positive_Number()
        {
            var nums = new[] { 0, 100 };
            var actual = Summator.Sum(nums);
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Zero_And_Negative_Number()
        {
            var nums = new[] { 0, -20 };
            var actual = Summator.Sum(nums);
            var expected = -20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Zero_And_Zero_Number()
        {
            var nums = new[] { 0, 0 };
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_MinusZero_And_Zero_Number()
        {
            var nums = new[] { -0, 0 };
            var actual = Summator.Sum(nums);
            var expected = -0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_MinusZero_And_MinusZero_Number()
        {
            var nums = new[] { -0, -0 };
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_One_Number()
        {
            var nums = new[] { -5 };
            var actual = Summator.Sum(nums);
            var expected = -5;
            Assert.AreEqual(expected, actual);
        }
    }
}