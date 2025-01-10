namespace GetSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int s = SumRec([1, 2, 3, 4]);
		}

		static int SumRec(int[] nums)
		{
			if (nums.Length == 0) return 0;
			return nums[0] + SumRec(nums[1..]);
		}
	}
}
