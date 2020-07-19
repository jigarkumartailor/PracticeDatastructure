// C# implementation to check if given Binary tree  
//is a BST or not  

/* Class containing left and right child of current  
 node and key value*/
using System;

public class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

namespace PracticeDatastructure
{
   public class BinaryTree
    {
        //Root of the Binary Tree  
        public Node root;

        /* 
         A program to check if a binary tree is BST or not
A binary search tree (BST) is a node based binary tree data structure which has the following properties.
• The left subtree of a node contains only nodes with keys less than the node’s key.
• The right subtree of a node contains only nodes with keys greater than the node’s key.
• Both the left and right subtrees must also be binary search trees.

From the above properties it naturally follows that:
• Each node (item in the tree) has a distinct key.
BST_ Binary Search Tree
        4
      /   \
     2     5
   /   \
  1     3

Not BST
        3
      /   \
     2     5
   /   \
  1     4

*/

        public virtual bool BST
        {
            get
            {
                return isBSTUtil(root, int.MinValue, int.MaxValue);
            }
        }

        /* Returns true if the given tree is a BST and its  
          values are >= min and <= max. */
        public virtual bool isBSTUtil(Node node, int min, int max)
        {
            /* an empty tree is BST */
            if (node == null)
            {
                return true;
            }

            /* false if this node violates the min/max constraints */
            if (node.data < min || node.data > max)
            {
                return false;
            }

            /* otherwise check the subtrees recursively  
            tightening the min/max constraints */
            // Allow only distinct values  
            return (isBSTUtil(node.left, min, node.data - 1) && isBSTUtil(node.right, node.data + 1, max));
        }

        /* Driver program to test above functions */
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(4);
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);

            if (tree.BST)
            {
                Console.WriteLine("IS BST");
            }
            else
            {
                Console.WriteLine("Not a BST");
            }
        }
    }
}
