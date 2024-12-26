using System.Text;

namespace MoveZeroes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = [0, 1, 0, 3, 12];
			//[1, 3, 12, 0, 0]
			new Solution().MoveZeroesNormalOrder(arr);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int i in arr)
				stringBuilder.Append(i);
			Console.WriteLine(stringBuilder.ToString());
			Console.ReadLine();
		}
	}

	public class Solution
	{
		public void MoveZeroesMirrowOrder(int[] nums)
		{
			for (int left = 0, right = nums.Length - 1; left < right; left++)
			{
				if (nums[left] == 0)
				{
					nums[left] = nums[right];
					nums[right] = 0;
					right--;
				}
			}
		}

		public void MoveZeroesNormalOrder(int[] nums)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i; j < nums.Length - 1; j++)
				{
					if (nums[j] == 0)
					{
						int tmp = nums[j];
						nums[j] = nums[j + 1];
						nums[j + 1] = tmp;
					}
				}
			}
		}
	}
}
