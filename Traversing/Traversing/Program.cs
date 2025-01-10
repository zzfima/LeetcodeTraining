
namespace Traversing
{
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

            //PreOrder: root->left->right
            PreOrder(tree);
            Console.WriteLine();

            //InOrder: left->root->right
            InOrder(tree);
            Console.WriteLine();

            //PostOrder: left->right->root
            PostOrder(tree);
            Console.WriteLine();
        }

        private static void PreOrder(TreeNode tree)
        {
            if (tree == null) return;
            Console.Write(tree.Val + " ");
            PreOrder(tree.Left);
            PreOrder(tree.Right);
        }

        private static void InOrder(TreeNode tree)
        {
            if (tree == null) return;
            InOrder(tree.Left);
            Console.Write(tree.Val + " ");
            InOrder(tree.Right);
        }

        private static void PostOrder(TreeNode tree)
        {
            if (tree == null) return;
            PostOrder(tree.Left);
            PostOrder(tree.Right);
            Console.Write(tree.Val + " ");
        }
    }
}
