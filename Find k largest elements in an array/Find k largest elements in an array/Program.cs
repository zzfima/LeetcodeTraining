
namespace Find_k_largest_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 23, 12, 9, 30, 2, 50 };
            int k = 3;

            List<int> res = kLargest(arr, k);
            foreach (int ele in res)
                Console.Write(ele + " ");

            Console.WriteLine("");

            res = kmin(arr, k);
            foreach (int ele in res)
                Console.Write(ele + " ");
        }

        private static List<int> kLargest(int[] arr, int k)
        {
            SortedSet<int> maximums = new SortedSet<int>();

            //fill first elements
            for (int i = 0; i < k; i++)
                maximums.Add(arr[i]);

            //start search big guys
            for (int i = k; i < arr.Length; i++)
                if (arr[i] > maximums.Min)
                {
                    maximums.Remove(maximums.Min);
                    maximums.Add(arr[i]);
                }

            return maximums.ToList();
        }

        private static List<int> kmin(int[] arr, int k)
        {
            SortedSet<int> minimums = new SortedSet<int>();

            //fill first elements
            for (int i = 0; i < k; i++)
                minimums.Add(arr[i]);

            //start search small guys
            for (int i = k; i < arr.Length; i++)
                if (arr[i] < minimums.Max)
                {
                    minimums.Remove(minimums.Max);
                    minimums.Add(arr[i]);
                }

            return minimums.ToList();
        }
    }
}
