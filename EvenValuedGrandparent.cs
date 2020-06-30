using System;

namespace Demo
{
    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(6);
            root.left = new TreeNode(7);
            root.left.left = new TreeNode(2);
            root.left.left.left = new TreeNode(9);
            root.left.right = new TreeNode(7);
            root.left.right.left = new TreeNode(1);
            root.left.right.right = new TreeNode(4);

            root.right = new TreeNode(8);
            root.right.left = new TreeNode(1);
            root.right.right = new TreeNode(3);
            root.right.right.right = new TreeNode(5);

            Console.WriteLine("Sum of Nodes with Even-Valued Grandparent: " + SumEvenGrandparent(root));
            Console.ReadKey();
        }

        /// <summary>
        /// Method to Sum of Nodes with Even-Valued Grandparent
        /// Input:
        ///           1
        ///          / \
        ///         3   8
        ///            / \
        ///           5   6
        ///          /
        ///         1

        /// Output: 11
        /// The only even nodes are 8 and 6 and
        /// the sum of their children is 5 + 6 = 11.

        /// Input:
        ///          2
        ///         / \
        ///        3   8
        ///       /   / \
        ///      2   5   6
        ///         /     \
        ///        1       3

        /// Output: 25
        /// 3 + 8 + 5 + 6 + 3 = 25
        /// 
        /// </summary>
        /// <param name="root">root of the tree</param>
        /// <returns>Sum of Nodes with Even-Valued Grandparent</returns>
        public static int SumEvenGrandparent(TreeNode root)
        {
            // node values are greater then 0, 
            // so, by default assuming parent node 
            // and grand parent node value for root as 0.
            return Helper(root, 0, 0);
        }

        /// <summary>
        /// Helper method to be called recursively, 
        /// for each node in the tree, to check  
        /// if it's grandparent node value is even or not.
        /// If it's even, then add node's value to the sum.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="parentVal"></param>
        /// <param name="grandParentSum"></param>
        /// <returns></returns>
        private static int Helper(TreeNode root, int parentVal, int grandParentSum)
        {
            // traversal to the branch, ends.
            if (root == null)
            {
                return 0;
            }

            int addToSum = 0;

            // if grand parent node sum is even and it is greater than 0.
            if (grandParentSum % 2 == 0 && grandParentSum > 0)
            {
                addToSum = root.val;
            }

            // current node become parent node
            // and current parent node become grand parent node
            // for both the child nodes.
            return addToSum
                + Helper(root.left, root.val, parentVal)
                    + Helper(root.right, root.val, parentVal);
        }
    }
}