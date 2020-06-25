using System;

namespace PracticeDatastructure
{
    //Given an array of integers, find the equilibrium index
    class EquilibriumIndex
    {
        static int equilibrium(int[] arr, int n)
        {
            int i, j;
            int leftsum, rightsum;

            /* Check for indexes one by  
             one until an equilibrium 
            index is found */
            for (i = 0; i < n; ++i)
            {

                // initialize left sum 
                // for current index i 
                leftsum = 0;

                // initialize right sum 
                // for current index i 
                rightsum = 0;

                /* get left sum */
                for (j = 0; j < i; j++)
                    leftsum += arr[j];

                /* get right sum */
                for (j = i + 1; j < n; j++)
                    rightsum += arr[j];

                /* if leftsum and rightsum are 
                 same, then we are done */
                if (leftsum == rightsum)
                    return i;
            }

            /* return -1 if no equilibrium  
             index is found */
            return -1;
        }

        // driver code 
        static void Main(string[] args)
        {
            int[] arr = { -7, 1, 5, 2, -4, 3, 0 };
            int arr_size = arr.Length;

            Console.Write(equilibrium(arr, arr_size));
        }
    }
}
