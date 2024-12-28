

namespace ZeroesMoveToEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] toEnd = MoveZeroes([2, 0, 0, 9, 3, 0, 1]); // -> 2 9 3 1 0 0 0
        }

        private static int[] MoveZeroes(int[] values)
        {
            //1. start loop with i on values
            //2. if zero found:
            //   2.1 find next index with not zero
            //   2.1 exchange value of i whith value of non zero

            int i;
            int notZeroIndex = -1;

            //1
            for (i = 0; i < values.Length; i++)
            {
                //2
                if (values[i] == 0)
                {
                    notZeroIndex = FindNextNonZeroIndex(values, i);

                    if (notZeroIndex == -1)
                        return values;

                    values[i] = values[notZeroIndex];
                    values[notZeroIndex] = 0;
                }
            }

            return values;

        }

        private static int FindNextNonZeroIndex(int[] values, int fromIndex)
        {
            for (int i = fromIndex; i < values.Length; i++)
            {
                if (values[i] != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
