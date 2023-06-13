/*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.*/

using System;


namespace Project2
{
    public class Solution
    {
        static void BubleSort(int[] nums, int[] indices)
        {
            int size = nums.Length;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        //Exchange of elements
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;

                        //Index exchange
                        int tempIndex = indices[j];
                        indices[j] = indices [j+1];
                        indices [j+1] = tempIndex;
                    }
                }
            }

        }
        static int[] TwoSum(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;

            int[] sortedIndices = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++) // preserve the original indexes before sorting
            {
                sortedIndices[i] = i;
            }
            
            BubleSort (nums, sortedIndices); // sort nums array and corresponding indexes

            while (l < r)
            {
                int sum = nums[l] + nums[r];

                if (sum == target) //if the sum is equal to the number, we return the indices of the given elements
                {
                    int index1 = sortedIndices[l];  
                    int index2 = sortedIndices[r];

                    return new int[]{index1, index2};
                  
                }
                if (sum < target)
                {
                    l++; //if the sum is less than the number, move to the right
                }
                else
                {
                    r--; //if the sum is greater than the number, move to the left
                }

            }
            return new int[0]; // return an empty array if no pair of elements with this sum is found
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //enter array elements and a number
            int[] nums = Array.ConvertAll(input.Split(','), int.Parse);
            int target = int.Parse(Console.ReadLine());

            int[] result = TwoSum(nums, target); // we derive the indices of the elements
            Console.WriteLine(string.Join(", ", result));

            Console.ReadKey();
            Console.ReadLine();
        }
    }
   
}
