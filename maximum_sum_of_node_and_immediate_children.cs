// C# program to find the node whose children  
// and node sum is maximum 
using System;
using System.Collections.Generic;

class NodeWithChildrenSum
{

    // Structure of a node of an n-ary tree  
    public class Node
    {
        public int key;
        public List<Node> child;
        public Node()
        {
            child = new List<Node>();
        }
    };

    // Utility function to create a new tree node  
    static Node newNode(int key)
    {
        Node temp = new Node();
        temp.key = key;
        return temp;
    }

    static int maxsum;

    // resultant node with max sum of children  
    // and node  
    static Node resNode;

    // Helper function to find the node  
    static void maxSumUtil(Node root)
    {
        // Base Case  
        if (root == null)
            return;

        // curr contains the sum of the root and  
        // its children  
        int currsum = root.key;

        // total no of children  
        int count = root.child.Count;

        // for every child call recursively  
        for (int i = 0; i < count; i++)
        {
            currsum += root.child[i].key;
            maxSumUtil(root.child[i]);
        }

        // if curr is greater than sum, update it  
        if (currsum > maxsum)
        {

            // resultant node  
            resNode = root;
            maxsum = currsum;
        }
        return;
    }

    // Function to find the node having max sum of  
    // children and node  
    static int maxSum(Node root)
    {

        // sum of node and its children  
        int maxsum = 0;

        maxSumUtil(root);

        // return the key of resultant node  
        return resNode.key;
    }

    // Driver code  
    public static void Main1(String[] args)
    {
        /* Let us create below tree  
                  1  
                / | \  
             2    3   16  
            / \     / | \  
           9   9   5  6  6   
        */

        Node root = newNode(1);
        (root.child).Add(newNode(2));
        (root.child).Add(newNode(3));
        (root.child).Add(newNode(16));
        (root.child[0].child).Add(newNode(9));
        (root.child[0].child).Add(newNode(9));
        (root.child[2].child).Add(newNode(5));
        (root.child[2].child).Add(newNode(6));
        (root.child[2].child).Add(newNode(6));

        Console.Write(maxSum(root));
    }
}
