namespace GetTail
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int l = GetArrayTail([4, 5, 6, 7, 8]);
		}

		static int GetArrayTail(int[] nums)
		{
			if (nums.Length == 1) return nums[0];

			return GetArrayTail(nums[1..]);
		}
	}
}
