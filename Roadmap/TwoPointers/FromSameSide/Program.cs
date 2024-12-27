namespace FromSameSide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = [1, 2, 3];
            int[] arr2 = [2, 3, 4];

            var pairs = GetPairsBF(arr1, arr2, 5);
        }

        static List<List<int>> GetPairsBF(int[] arr1, int[] arr2, int target)
        {
            var pairs = new List<List<int>>();

            for (int i = 0; i < arr1.Length; i++)
                for (int j = 0; j < arr2.Length; j++)
                    if (arr1[i] + arr2[j] == target)
                        pairs.Add(new List<int>() { i, j });

            return pairs;
        }
    }
}
