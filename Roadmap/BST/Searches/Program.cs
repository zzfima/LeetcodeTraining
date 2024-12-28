

namespace Searches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*         
                      5                    t1
                  /       \                
                 3         6               t2 t3
              /     \        \
             2       4         7           t4 t5 t6
           /
         1                                 t7
            */
            TreeNode t1 = new() { Value = 5 };

            TreeNode t2 = new() { Value = 3 };
            TreeNode t3 = new() { Value = 6 };

            TreeNode t4 = new() { Value = 2 };
            TreeNode t5 = new() { Value = 4 };
            TreeNode t6 = new() { Value = 7 };

            TreeNode t7 = new() { Value = 1 };


            t1.Left = t2;
            t1.Right = t3;

            t2.Left = t4;
            t2.Right = t5;
            t3.Right = t6;

            t4.Left = t7;

            bool b = IsValueExists(t1, 9);
            int i = FindMin(t1);
        }

        private static int FindMin(TreeNode t1)
        {
            TreeNode treeNode = t1;
            int min = 0;

            while (treeNode != null)
            {
                min = treeNode.Value;
                treeNode = treeNode.Left;
            }

            return min;
        }

        private static bool IsValueExists(TreeNode t1, int v)
        {
            TreeNode treeNode = t1;

            while (treeNode != null)
            {
                if (treeNode.Value == v) return true;
                else if (v > treeNode.Value)
                    treeNode = treeNode.Right;
                else
                    treeNode = treeNode.Left;
            }

            return false;
        }

        public class TreeNode
        {
            public int Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }
        }
    }
}