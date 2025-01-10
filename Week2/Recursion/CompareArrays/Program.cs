namespace CompareArrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool isSame = IsArraysSame([4, 5, 6, 7, 8], [4, 5, 6, 7, 8]);
			isSame = IsArraysSame([4, 5, 2, 7, 8], [4, 5, 6, 7, 8]);
		}

		static bool IsArraysSame(int[] arr1, int[] arr2)
		{
			if (arr1.Length == 0 && arr2.Length != 0) return false;
			if (arr1.Length != 0 && arr2.Length == 0) return false;
			if (arr1.Length == 0 && arr2.Length == 0) return true;

			if (arr1[0] != arr2[0]) return false;


			return IsArraysSame(arr1[1..], arr2[1..]);
		}
	}
}
