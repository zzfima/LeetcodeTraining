using MaximumSubarray;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            int expected = 6;
            int actual = new Algo().MaxSubArray(nums);

            Assert.AreEqual(expected, actual);
        }
    }
}