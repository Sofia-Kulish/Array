using System;

namespace Project2
{

    class RemovalElement
    {

        public int counter; //public variable to count the number of deleted items
        private int size;
        private int?[] number; //array nullable of integers
        private int element;

        public RemovalElement(int size, int element) //constructor with parameters
        {
            this.element = element;
            this.size = size;
            number = new int?[size];
        }

        public int?[] GetNumber(int index) //getter to get array element by index
        {
            try
            {
                if (index >= 0 && index <= number.Length)
                {
                    return number;
                }

                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }

            catch (IndexOutOfRangeException ex) //exception handling IndexOutOfRangeException
            {
                Console.WriteLine("Error: " + ex.Message);

                return null;
            }
        }

        public void SetNumber(int index, int? numb) // setter for changing an array element by index
        {
            try
            {
                if (index >= 0 && index < number.Length)
                {
                    number[index] = numb;
                }

                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
            catch (IndexOutOfRangeException ex) // exception handling IndexOutOfRangeException
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        public int GetSize(int size) //getter to get the size of the array 
        {
            try
            {
                if (size >= 0 && size < number.Length)
                {
                    return size;
                }
                else
                {
                    throw new IndexOutOfRangeException("Ivalid size");
                }
            }

            catch (IndexOutOfRangeException ex) //exception handling IndexOutOfRangeException 
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;

            }

        }

        public void SetSize(int NewSize) //setter to change the size of the array
        {
            try
            {
                if (NewSize >= 0 && NewSize < number.Length)
                {
                    size = NewSize;
                }
                else
                {
                    throw new IndexOutOfRangeException("Ivalid size");
                }
            }

            catch (IndexOutOfRangeException ex) //exception handling IndexOutOfRangeException
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        public int GetElement() //getter to access the element
        {
            try
            {
                if (element >= 0 && element < number.Length)
                {
                    return element;
                }
                else
                {
                    throw new IndexOutOfRangeException("Ivalid element");
                }
            }
            catch (IndexOutOfRangeException ex) //exception handlinng IndexOutOfRangeException
            {
                Console.WriteLine("Error: " + ex.Message);

                return -1;
            }
        }

        public void SetElement(int NewElement) //setter to change element
        {
            try
            {
                if (NewElement >= 0 && NewElement < number.Length)
                {
                    element = NewElement;

                }
                else
                {
                    throw new IndexOutOfRangeException("Ivalid element");
                }
            }
            catch (IndexOutOfRangeException ex) // exception handline IndexOutOfRangeException
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

       public void Print()//method for outputting array elements
        {
            
        }

       public void Removal()
        {
            counter = 0;

            for (int i = 0; i < size; i++)
            {
                if (number[i] == element)//checing that the entered  element corresponds to an element in the array
                {
                    counter++; // increase the counter
                    number[i] = null;//assign a value to the found element

                    if (i != number.Length - 1) //check if the element is not the last one
                    {

                        for (int j = i; j < size - 1; j++) //move the found element to the last position
                        {
                            int? tmp = number[j];
                            number[j] = number[j + 1];
                            number[j + 1] = tmp;
                            
                        }

                        i--;
                    }

                }
            }
        }
    };

    class Program
    {

        static void Main(string [] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            //The user enters an array element to be moved and deleted
            Console.WriteLine("Enter the element of the array to delete: ");
            int element = int.Parse(Console.ReadLine());


            RemovalElement myObject = new RemovalElement (size, element); //creating an object
            int?[] newArray = new int?[size]; //creating a new array, type - int?

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i<size; i++)
            {
                newArray[i] = (int?)int.Parse(Console.ReadLine()); //read the line from the console and type in int
            }

           if (newArray.Length == myObject.GetNumber(size).Length)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    myObject.SetNumber(i, newArray[i]);

                }
            }
            else
                Console.WriteLine("The size of newArray does not mach the size of the array in myobject.");

            //getting an array via a getter to output an array
            int?[] number = myObject.GetNumber(size);
           
            myObject.Removal();
            int counterValue = myObject.counter; //variable to determine the number of elements we removed
            Console.WriteLine("Array: ");
            Console.Write(counterValue + ", ");

            foreach (var numb in number)
            {
                Console.Write( numb + " ");
            }
            Console.ReadKey();
        }
    };
}
