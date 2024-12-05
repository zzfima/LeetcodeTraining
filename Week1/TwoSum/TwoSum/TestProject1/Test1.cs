using Logic;

namespace TestProject1
{
	[TestClass]
	public sealed class Test1
	{
		[TestMethod]
		public void TestBruteForce1()
		{
			TwoSum twoSum = new TwoSum();

			int[] nums = [2, 7, 11, 15];
			int[] expected = [0, 1];
			int target = 9;
			int[] actual = twoSum.BruteForceAlgo(nums, target);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestBruteForce2()
		{
			TwoSum twoSum = new TwoSum();

			int[] nums = [3, 2, 4];
			int[] expected = [1, 2];
			int target = 6;
			int[] actual = twoSum.BruteForceAlgo(nums, target);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestHash1()
		{
			TwoSum twoSum = new TwoSum();

			int[] nums = [2, 7, 11, 15];
			int[] expected = [0, 1];
			int target = 9;
			int[] actual = twoSum.HashAlgo(nums, target);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestHash2()
		{
			TwoSum twoSum = new TwoSum();

			int[] nums = [3, 2, 4];
			int[] expected = [1, 2];
			int target = 6;
			int[] actual = twoSum.HashAlgo(nums, target);

			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
