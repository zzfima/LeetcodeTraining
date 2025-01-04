namespace CompareTrees
{
	public class TreeNode : IEquatable<TreeNode>
	{
		public int val;
		public TreeNode left;
		public TreeNode right;

		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}

		public bool Equals(TreeNode? other)
		{
			return val == other.val;
		}
	}

}
