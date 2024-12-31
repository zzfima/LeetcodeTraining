namespace MaximumBinaryTreeDepth
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TreeNode node1 = new TreeNode(1);
			TreeNode node2 = new TreeNode(2);
			TreeNode node3 = new TreeNode(3);
			TreeNode node4 = new TreeNode(4);

			node1.left = node2;
			node1.right = node3;
			node3.left = node4;

			int maxDepth = MaxDepth(node1);

			Console.ReadLine();
		}

		static int MaxDepth(TreeNode root)
		{
			if (root == null) return 0;

			int leftDepth = MaxDepth(root.left);
			int rightDepth = MaxDepth(root.right);

			return Math.Max(leftDepth, rightDepth) + 1;
		}
	}
}
