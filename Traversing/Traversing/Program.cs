
internal class Program
{
    static void Main(string[] args)
    {
        TreeNode tree = new TreeNode(1);
        tree.Left = new TreeNode(2);
        tree.Right = new TreeNode(3);
        tree.Left.Left = new TreeNode(4);
        tree.Left.Right = new TreeNode(5);
        tree.Right.Left = new TreeNode(6);
        tree.Right.Right = new TreeNode(7);

        Console.WriteLine("PreOrder: root->left->right");
        DFS.PreOrder(tree);
        Console.WriteLine();

        Console.WriteLine("InOrder: left->root->right");
        DFS.InOrder(tree);
        Console.WriteLine();

        Console.WriteLine("PostOrder: left->right->root");
        DFS.PostOrder(tree);
        Console.WriteLine();

        Console.WriteLine("Level order: level by level");
        BFS.Levelrder(tree);
        Console.WriteLine();

        Console.WriteLine("Travel Iterative DFS");
        DFS.TravelIterative(tree);
        Console.WriteLine();
    }
}
