
namespace InvertBinaryTree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
             * Input:  [1,2,3,4,5,6,7]
             * Output: [1,3,2,7,6,5,4]
             */
			TreeNode root = CreateTreeFromArray([1, 2, 3, 4, 5, 6, 7], 0);
			TreeNode reversedTree = ReverseTree(root);

			Console.ReadLine();
		}

		private static TreeNode CreateTreeFromArray(int[] ints, int i)
		{
			if (ints == null || ints.Length == 0)
			{
				return new TreeNode();
			}


			TreeNode root = new TreeNode(ints[i]);

			if (i * 2 + 1 >= ints.Length)
				return root;

			root.Left = CreateTreeFromArray(ints, i * 2 + 1);
			root.Right = CreateTreeFromArray(ints, i * 2 + 2);

			return root;
		}

		private static TreeNode ReverseTree(TreeNode root)
		{
			throw new NotImplementedException();
		}
	}

	public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
	{
		public int Val = val;
		public TreeNode Left = left;
		public TreeNode Right = right;
	}
}
