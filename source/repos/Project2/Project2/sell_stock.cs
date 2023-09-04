using System;
using System.Globalization;
using System.Linq;

namespace Project2
{
    internal class SellStock
    {
        public int size; //array size
        public int[] prices; // an array of elements containing shares 

        public SellStock(int size) //constructor with one parameter
        {
            this.size = size;
            this.prices = new int[size];
        }

        // the method for determining the maximum return on shares
        public int Stock () 
        {
        // to determine the biggest profit, you need to get the sum of the difference between the next and previous day 
            int maximumElement = 0; // the difference between the next day and the previous day
            int maximum = 0; // the sum of the difference between the next day and the previous day

            for (int i=1; i<size; i++)
            {
                maximumElement = prices[i] - prices[i-1];
                
                if (maximumElement > 0) //the difference is greater than zero we add the difference to our variable
                {
                    maximum += maximumElement;
                }

            }

            return maximum; // the variable that holds the maximum possible profit
        }
    };

    class Program
    {
        static void Main (string [] arg)
        {
            Console.WriteLine("Enter the number of share prices");
            int size = int.Parse (Console.ReadLine());

            SellStock myObject = new SellStock(size); //allocation of memory for an array of elements 

            Console.WriteLine("Enter the prices of this promotion: ");
            
            for (int i=0; i<size; i++) // filling the array by the user
            {
                myObject.prices[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Maximum profit: " + myObject.Stock ());

            Console.ReadKey();
        }
    };
}
