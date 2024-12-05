﻿namespace Logic
{
	public class TwoSum
	{
		public int[] Algo1(int[] nums, int target)
		{
			int[] indexes = new int[2];

			for (int i = 0; i < nums.Length; i++)
				for (int j = i + 1; i < nums.Length; i++)
					if (nums[i] + nums[j] == target)
					{
						indexes[0] = i;
						indexes[1] = j;
						return indexes;
					}

			return null;
		}
	}
}
