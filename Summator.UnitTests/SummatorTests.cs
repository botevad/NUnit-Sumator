using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_Three_Positive_Numbers()
        {
            var nums = new int[] { 1, 2, 3 };
            var actual = Summator.Sum(nums);
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Two_Negative_Numbers()
        {
            var nums = new int[] { -1, -80 };
            var actual = Summator.Sum(nums);
            var expected = -81;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Negative_And_Positive_Number()
        {
            var nums = new int[] { -1, 100 };
            var actual = Summator.Sum(nums);
            var expected = 99;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Zero_And_Positive_Number()
        {
            var nums = new int[] { 0, 100 };
            var actual = Summator.Sum(nums);
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Zero_And_Negative_Number()
        {
            var nums = new int[] { 0, -20 };
            var actual = Summator.Sum(nums);
            var expected = -20;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Zero_And_Zero_Number()
        {
            var nums = new int[] { 0, 0 };
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_MinusZero_And_Zero_Number()
        {
            var nums = new int[] { -0, 0 };
            var actual = Summator.Sum(nums);
            var expected = -0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_MinusZero_And_MinusZero_Number()
        {
            var nums = new int[] { -0, -0 };
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_One_Number()
        {
            var nums = new int[] { -5 };
            var actual = Summator.Sum(nums);
            var expected = -5;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Zero_Numbers()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_Big_Numbers()
        {
            var nums = new int[] {2000000000, 2000000000, 2000000000};
            var actual = Summator.Sum(nums);
            var expected = 6000000000;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_Two_Positive_Numbers()
        {
            var nums = new double[] { 5, 7 };
            var actual = Summator.Average(nums);
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_Positive_Negative_Numbers()
        {
            var nums = new double[] { 6, -12 };
            var actual = Summator.Average(nums);
            var expected = -3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_Two_Negative_Number()
        {
            var nums = new double[] { -6, -12 };
            var actual = Summator.Average(nums);
            var expected = -9;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_Negative_Zero_Numbers()
        {
            var nums = new double[] { -6, 0 };
            var actual = Summator.Average(nums);
            var expected = -3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_Big_Numbers()
        {
            var nums = new double[] { 2000000000, 2000000000 };
            var actual = Summator.Average(nums);
            var expected = 2000000000;
            Assert.AreEqual(expected, actual);
        }





    }
}