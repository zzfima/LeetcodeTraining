using Logic;

namespace TestProject1
{
	[TestClass]
	public sealed class Test1
	{
		[TestMethod]
		public void TestMethod1()
		{
			TwoSum twoSum = new TwoSum();

			int[] nums = [2, 7, 11, 15];
			int[] expected = [0, 1];
			int target = 9;
			int[] actual = twoSum.Algo1(nums, target);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			TwoSum twoSum = new TwoSum();

			int[] nums = [3, 2, 4];
			int[] expected = [2, 1];
			int target = 6;
			int[] actual = twoSum.Algo1(nums, target);

			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
