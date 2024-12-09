using System.Text;

namespace SortingAlgo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = [5, 3, 6, 2, 10];
			SelectionSort(arr);
			StringBuilder sb = new StringBuilder();
			foreach (int i in arr)
				sb.Append(i.ToString() + " ");
			Console.WriteLine(sb.ToString());

			Console.ReadLine();
		}

		static void SelectionSort(int[] ints)
		{
			for (int i = 0; i < ints.Length; i++)
			{
				int minIndex = FindMinIndex(ints, i);
				int tmp = ints[i];
				ints[i] = ints[minIndex];
				ints[minIndex] = tmp;
			}
		}

		private static int FindMinIndex(int[] ints, int v)
		{
			int minIndex = v;
			for (int i = v; i < ints.Length; i++)
			{
				if (ints[minIndex] > ints[i])
					minIndex = i;
			}

			return minIndex;
		}
	}
}
