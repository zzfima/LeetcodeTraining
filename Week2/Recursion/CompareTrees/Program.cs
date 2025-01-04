namespace CompareTrees
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TreeNode treeNode1 = GetTree();
			treeNode1.left.right = new TreeNode(1);
			TreeNode treeNode2 = GetTree();

			bool isSame = IsSameTrees(treeNode1, treeNode2);
		}

		static bool IsSameTrees(TreeNode treeNode1, TreeNode treeNode2)
		{
			if (treeNode1 == null && treeNode2 == null)
				return true;
			if (treeNode1 == null && treeNode2 != null)
				return false;
			if (treeNode1 != null && treeNode2 == null)
				return false;
			if (!treeNode1.Equals(treeNode2))
				return false;

			return IsSameTrees(treeNode1.left, treeNode2.left) && IsSameTrees(treeNode1.right, treeNode2.right);
		}

		static TreeNode GetTree()
		{
			TreeNode node1 = new TreeNode(1);
			TreeNode node2 = new TreeNode(2);
			TreeNode node3 = new TreeNode(3);
			TreeNode node4 = new TreeNode(4);

			node1.left = node2;
			node1.right = node3;
			node3.left = node4;
			return node1;
		}
	}
}
