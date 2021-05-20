using System;

namespace Algorithm.ValidateBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TreeNode tree3 = new TreeNode(3, null, null);
            TreeNode tree6 = new TreeNode(6, null, null);
            TreeNode tree4 = new TreeNode(4, tree3, tree6);
            TreeNode tree1 = new TreeNode(1, null, null);
            TreeNode tree5 = new TreeNode(5, tree1, tree6);

            IsValidBST(tree5);
        }

        public static bool IsValidBST(TreeNode root)
        {
            return IsValid(root, null, null);
        }

        public static bool IsValid(TreeNode root, int? left, int? right)
        {
            if (root == null)
            {
                return true;
            }

            var val = root.val;

            if (val <= right || val >= left)
            {
                return false;
            }
            if (!IsValid(root.left, val, right) || !IsValid(root.right, left, val))
                return false;
            return true;
        }
    }
    public class TreeNode
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
    }
}
