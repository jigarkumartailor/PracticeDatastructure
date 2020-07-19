using System;
using System.Collections.Generic;
using System.Text;
/*
Input: Tree =
                 5
               /   \
              10    6
             /  \ 
            11   8  
Output: 11
Explanation:
The tree node weights are:
5 -> 5
10 -> 1 + 0 = 1
6 -> 6
11 -> 1 + 1 = 2
8 -> 8
Here, digit sum for nodes
containing 11, 6 and 8 are even.
Hence, the maximum weighing
even digit sum node is 11.


Input: Tree =
                 1
                /  \
               4    7
              / \  / \
             11 3 15  8
Output: 15
Explanation:
Here, digit sum for nodes containing
4, 11, 15 and 8 are even. 
Hence, the maximum weighing 
even digit sum node is 15. 
*/
namespace PracticeDatastructure
{
    class maximum_Even_Digit_Sum_Node
    {
        public static void Main1()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(10);
            root.left.left = new TreeNode(11);
            root.left.right = new TreeNode(8);

            root.right = new TreeNode(6);
           // root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(8);

            Console.WriteLine("Maximum Even Digit Sum node in the given tree :- " + MaxEvenDigitSum(root,new List<int>()));
            Console.ReadKey();
        }
        static int maxnum;

        // resultant node with max sum of children  
        // and node  
        static TreeNode resNode;
        public static int MaxEvenDigitSum(TreeNode root, List<int> parents)
        {
            if (root == null) return 0;

            List<int> newParents = new List<int>(parents);
            newParents.Add(root.val);

            int num = digitSum(root.val);
            if (num % 2 == 0)
            {
                if (maxnum < root.val)
                {
                    resNode = root;
                    maxnum = root.val;
                }             
            }
            if (root.left != null){
                int left = MaxEvenDigitSum(root.left, newParents);
            }
            if (root.right != null)
            {
                int right = MaxEvenDigitSum(root.right, newParents);
            }
            
            return resNode.val;
        }

        public static int digitSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += (num % 10);
                num /= 10;
            }
            return sum;
        }
    }
}
