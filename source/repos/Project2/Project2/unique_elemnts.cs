using System;
using System.Xml.Schema;

namespace Project2
{
    internal class UniqueElements
    {
        public int size;
        public int[] nums;

        public UniqueElements (int size)
        {
            this.size = size; 
            this.nums = new int [size];
        }

        public void Unique ()
        {
            int counter = 0;

            for (int i=1; i<nums.Length;i++)
            {
                if (counter + i == nums.Length)
                {
                    break; 
                }

                if (nums[i] == nums[i-1])
                {
                    counter++;
                    nums[i] = -1;
                    
                            for (int j = i; j < nums.Length - 1; j++)
                            {
                                int tmp = nums[j];
                                nums[j] = nums[j + 1];
                                nums[j + 1] = tmp;
                            }

                            i--;

                }
            }
        }

    };

    class  Program
    {
        static void Main (string [] arg)
        {
            Console.WriteLine("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());

            UniqueElements myObject = new UniqueElements(size);

            Console.WriteLine("Enter the elements of the array: ");
            for (int i=0; i<size;i++)
            {
                myObject.nums[i] = int.Parse(Console.ReadLine());
            }

            myObject.Unique();

            Console.WriteLine("Array: ");
            foreach (var number in myObject.nums)
            {
                
                
                    Console.Write(number + ", ");
                
            }

            Console.ReadKey();
        }

    };
}
