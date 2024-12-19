
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
			TreeNode reversedTree = InvertTree(root);

			Console.ReadLine();
		}

		static TreeNode InvertTree(TreeNode root)
		{
			if (root == null)
				return null;

			//invert children
			TreeNode tmp = root.left;
			root.left = root.right;
			root.right = tmp;

			//do recursive operation on left child
			if (root.left != null)
				root.left = InvertTree(root.left);


			//do recursive operation on right child
			if (root.right != null)
				root.right = InvertTree(root.right);

			return root;
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

			root.left = CreateTreeFromArray(ints, i * 2 + 1);
			root.right = CreateTreeFromArray(ints, i * 2 + 2);

			return root;
		}
	}

	public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
	{
		public int val = val;
		public TreeNode left = left;
		public TreeNode right = right;
	}
}
