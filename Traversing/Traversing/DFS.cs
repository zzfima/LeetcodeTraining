public static class DFS
{
    public static void InOrder(TreeNode tree)
    {
        if (tree == null) return;
        InOrder(tree.Left);
        Console.Write(tree.Val + " ");
        InOrder(tree.Right);
    }

    public static void PostOrder(TreeNode tree)
    {
        if (tree == null) return;
        PostOrder(tree.Left);
        PostOrder(tree.Right);
        Console.Write(tree.Val + " ");
    }

    public static void TravelIterative(TreeNode tree)
    {
        if (tree == null) return;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(tree);

        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            Console.Write(node.Val + " ");

            if (node.Left != null) stack.Push(node.Left);
            if (node.Right != null) stack.Push(node.Right);
        }
    }

    public static void PreOrder(TreeNode tree)
    {
        if (tree == null) return;
        Console.Write(tree.Val + " ");
        PreOrder(tree.Left);
        PreOrder(tree.Right);
    }
}