namespace OppositeSides
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isSumExists = SumOfTwoNumsInSorteArray([2, 4, 5, 6, 8, 9, 14, 15, 16], 1);
        }

        static bool SumOfTwoNumsInSorteArray(int[] nums, int targetSum)
        {
            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                int currentSum = nums[left] + nums[right];
                if (currentSum == targetSum)
                    return true;
                else if (currentSum > targetSum)
                    right--;
                else if (currentSum < targetSum)
                    left++;
            }

            return false;
        }
    }
}
