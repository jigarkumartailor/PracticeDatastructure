using System;

namespace PracticeDatastructure
{
    //The maximum subarray problem is the task of finding the contiguous subarray within a one-dimensional array 
    //of numbers which has the largest sum.
    //For example, for the sequence of values −2, 1, −3, 4, −1, 2, 1, −5, 4; the contiguous subarray 
    //with the largest sum is 4, −1, 2, 1, with sum 6

    class MaximumSubarrayProblem
    {
        static void Main1()
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int[] b = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.Write("Maximum contiguous sum is " +
                                    maxSubArraySum(a));
            Console.Write("Maximum contiguous sum is " +
                                    maxSubArraySum(b));
        }

        static int maxSubArraySum(int[] arr)
        {
            int size = arr.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + arr[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }
    }
}
