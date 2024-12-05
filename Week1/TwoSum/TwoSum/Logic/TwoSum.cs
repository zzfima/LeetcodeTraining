namespace Logic
{
	public class TwoSum
	{
		//time complexity O(n^2), space complexity O(1)
		public int[] BruteForceAlgo(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
				for (int j = i + 1; j < nums.Length; j++)
					if (nums[i] + nums[j] == target)
						return new int[] { i, j };

			throw new Exception("No such indexes");
		}

		//time complexity O(n), space complexity O(n)
		public int[] HashAlgo(int[] nums, int target)
		{
			//First pass - fill dictionary
			//Dictionary: value, index
			Dictionary<int, int> hash = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
				hash[nums[i]] = i;

			//Second pass search num
			for (int i = 0; i < nums.Length; i++)
			{
				int numToNeed = target - nums[i];
				if (hash.ContainsKey(numToNeed) && hash[numToNeed] != i)
					return new int[] { i, hash[numToNeed] };
			}

			throw new Exception("No such indexes");
		}
	}
}
