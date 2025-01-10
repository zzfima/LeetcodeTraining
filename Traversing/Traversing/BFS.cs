public static class BFS
{
    public static void Levelrder(TreeNode tree)
    {
        if (tree == null) return;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(tree);

        while (queue.Count > 0)
        {
            var e = queue.Dequeue();
            Console.Write(e.Val + " ");

            if (e.Left != null) queue.Enqueue(e.Left);
            if (e.Right != null) queue.Enqueue(e.Right);
        }
    }
}