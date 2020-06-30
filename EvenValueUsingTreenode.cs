using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDatastructure
{
    class EvenValueUsingTreenode
    {
        public static int SumEvenGrandParent(TreeNode root, List<int> parents)
        {
            if (root == null) return 0;

            List<int> newParents = new List<int>(parents);
            newParents.Add(root.val);
            int left = SumEvenGrandParent(root.left, newParents);
            int right = SumEvenGrandParent(root.right, newParents);

            if (parents != null && parents.Count >= 2 && parents[parents.Count - 2] % 2 == 0)
            {
                return left + right + root.val;
            }

            return left + right;
        }

        public int SumEvenGrandParent(TreeNode root)
        {
            return SumEvenGrandParent(root, new List<int>());
        }

        public static void Main()
        {
            TreeNode root = new TreeNode(6);
            root.left = new TreeNode(7);
            root.left.left = new TreeNode(2);
            root.left.left.left = new TreeNode(9);
            root.left.right = new TreeNode(7);
            root.left.right.right = new TreeNode(4);

            root.right = new TreeNode(8);
            root.right.left = new TreeNode(1);
            root.right.right = new TreeNode(3);
            root.right.right.right = new TreeNode(5);

            Console.WriteLine("Sum of Nodes with even value:" + SumEvenGrandParent(root, new List<int>()));
        }
    }
}
