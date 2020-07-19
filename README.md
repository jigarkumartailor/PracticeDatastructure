1) A program to check if a binary tree is BST or not

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

   File Name: Binary_Search_Tree _BST.cs


2) Given an array of integers, find the equilibrium index

        Input: A[] = {-7, 1, 5, 2, -4, 3, 0}
        Output: 3
        3 is an equilibrium index, because:
        A[0] + A[1] + A[2] = A[4] + A[5] + A[6]

   File Name: EquilibriumIndex.cs

3) Method to Sum of Nodes with Even-Valued Grandparent

          Input:
                   1
                  / \
                 3   8
                    / \
                   5   6
                  /
                 1

         Output: 11
            The only even nodes are 8 and 6 and
            the sum of their children is 5 + 6 = 11.

         Input:
                  2
                 / \
                3   8
               /   / \
              2   5   6
                 /     \
                1       3

         Output: 25
            3 + 8 + 5 + 6 + 3 = 25

    File Name: EvenValuedGrandparent.cs

4) Maximum Even Digit Sum node in the given tree

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

    File Name: maximum_Even_Digit_Sum_Node.cs


5) program to find the node whose immediate children and node's sum is maximum 

            Input: Tree =
                          1  
                        / | \  
                       2  3  16  
                      / \   / | \  
                     9   9 5  6  6  
            Output: 16
            

    File Name: maximum_sum_of_node_and_immediate_children.cs


6) program to find the node whose immediate children's sum is maximum 

            Input: Tree =
                          1  
                        / | \  
                       2  3  10  
                      / \   / | \  
                     9   9 5  6  6  
            Output: 2
            

    File Name: maximum_sum_of_immediate_children.cs

7) The maximum subarray problem is the task of finding the contiguous subarray within a one-dimensional array 
   of numbers which has the largest sum.

           For example, for the sequence of values −2, 1, −3, 4, −1, 2, 1, −5, 4 the contiguous subarray 
           with the largest sum is 4, −1, 2, 1, with sum 6
           contiguous subarray -->  4 + (−1) + 2 + 1 = 6

           for the sequence of values -2, -3, 4, -1, -2, 1, 5, -3  the contiguous subarray 
           with the largest sum is 4, −1, 2, 1, with sum 7
           contiguous subarray -->  4 + (-1) + (-2) + 1 + 5 = 7

   File Name: MaximumSubarrayProblem.cs
