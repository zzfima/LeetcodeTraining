namespace GetLength
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int l = GetLenghtArray([4, 5, 6, 7, 8]);
		}

		static int GetLenghtArray(int[] nums)
		{
			if (nums.Length == 0) return 0;

			return 1 + GetLenghtArray(nums[1..]);
		}
	}
}
