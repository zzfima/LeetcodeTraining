
namespace SortedSquareArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [-4, -1, 0, 3, 10];

            int[] sortedSquare = SortSquare(arr);
        }

        private static int[] SortSquare(int[] arr)
        {
            Stack<int> stack = new Stack<int>();

            int i = 0;
            int j = arr.Length - 1;

            while (i <= j)
            {
                int i_pow_2 = arr[i] * arr[i];
                int j_pow_2 = arr[j] * arr[j];

                if (i_pow_2 >= j_pow_2)
                {
                    stack.Push(i_pow_2);
                    i++;
                }
                else if (j_pow_2 >= i_pow_2)
                {
                    stack.Push(j_pow_2);
                    j--;
                }
                else
                {
                    i++;
                }
            }

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = stack.Pop();
            }

            return arr;
        }
    }
}
