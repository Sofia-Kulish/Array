using System;

namespace Project2
{
    internal class Solution1
    {
        public static void Merge (int[] nums1, int m, int [] nums2, int n)
        {
            int index1 = m - 1; // Index of the last element in nums1
            int index2 = n - 1; // Index of the last element in nums2
            int mergetIndex = m + n - 1; // The index of the last element in the combined array nums1

            while (index1 >=0 && index2 >=0) // Merging arrays in ascending order
            {
                if (nums1[index1] < nums2[index2])
                {
                    nums1[mergetIndex] = nums2[index2];
                    index2--;
                }
                else
                {
                    nums1[mergetIndex] = nums1[index1];
                    index1--;
                }
                mergetIndex--;
            }
            // Adding the remainders from nums2 in case the elements of nums1 are already sorted
            while (index2>=0)
            {
                nums1[mergetIndex] = nums2[index2];
                index2--;
                mergetIndex--;
            }
        }
        static void Main (string [] args)
        {
            Console.WriteLine("Enter the elements of the nums1 array, separated by a space:");
            string nums1Input = Console.ReadLine();
            int[] nums1 = Array.ConvertAll(nums1Input.Split(','), int.Parse);

            Console.WriteLine("Enter the elements of the nums2 array, separated by a space:");
            string nums2Input = Console.ReadLine();
            int[] nums2 = Array.ConvertAll(nums2Input.Split(','), int.Parse);

            Console.WriteLine("Enter the number of elements in nums1:");
            int m = int.Parse (Console.ReadLine());

            Console.WriteLine("Enter the number of elements in nums2:");
            int n = int.Parse(Console.ReadLine());

            Merge(nums1, m, nums2, n); // Call function to merge and sort arrays

            Console.WriteLine("Result: "); // Output the result

            foreach (int num in nums1)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
