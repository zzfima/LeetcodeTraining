namespace MissingNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int i = MissingNumberFind([3, 0, 1]);
		}

		static int MissingNumberFind(int[] nums)
		{
			int sum = 0;

			for (int i = 0; i < nums.Length; i++)
				sum += nums[i];

			int arithmeticProgressionSum = CalculateArithmeticProgressionSum(nums.Length);
			return arithmeticProgressionSum - sum;
		}

		static int CalculateArithmeticProgressionSum(int n)
		{
			//Sn = n/2 [2a + (n - 1) d]
			return (int)((n / 2.0f) * (1 + n));
		}
	}
}
