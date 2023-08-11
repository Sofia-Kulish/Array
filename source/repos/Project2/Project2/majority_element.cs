using System;
using System.Runtime.Remoting.Messaging;

namespace Project2
{
    internal class ElementOfTheMajority
    {
        public int size;
        public int[] nums;

        public ElementOfTheMajority (int size) //constructor with one parameter
        {
            this.size = size;
            this.nums = new int[size];
        }

        public int Majority () //method for determining the majority element
        {
            int counter = 0; // to count the number of elements in an array
            int element = 0; // variable to compare the element with the next anes in the array

            for (int i=0; i<size; i++)
            {
                if (element != nums[i]) //we check that our counter does not count the same number in the array several times
                {
                    element = nums[i]; //we assign the first element of the array to the variable

                    for (int j = i+1; j < size; j++)
                    {
                        if (element == nums[j]) // the current element is equal to the following then we increase the counter
                        {
                            counter++;
                        }
                    }

                }
                //the  majority element is the element that occurs more than - size/2
                    if (counter > (size / 2))
                    {
                        break;
                    }
                    else
                    {
                        counter = 0; //if we did not find a suitable element, we reset our counter for further search
                }
                
            }

            return element ; //we return the element that occurs most often in the array
        }
    };

    class Program
    {
        static void  Main (string [] arg)
        {
            Console.WriteLine("Enter  the size of the array: ");
            int size = int.Parse(Console.ReadLine());

           ElementOfTheMajority myObject = new ElementOfTheMajority(size);

            //enter array elements
            Console.WriteLine("Enter the elements of the array: ");
            for (int i=0; i< size; i++)
            {
                myObject.nums[i] = int.Parse( Console.ReadLine());
                    
            }

            //call the method that searches for the majority element
           Console.WriteLine( "In this array, the majority elements is - " + myObject.Majority());

            Console.ReadKey();
        }
    };
}
