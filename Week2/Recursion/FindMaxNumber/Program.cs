namespace FindMaxNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int max = FindMax([3, 7, 1, 9, 3, 8, 11, 2, 100]);
		}

		static int FindMax(int[] nums)
		{
			if (nums.Length == 1) return nums[0];
			if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

			int middle = nums.Length / 2;

			return Math.Max(FindMax(nums[..middle]), FindMax(nums[middle..]));
		}
	}
}
