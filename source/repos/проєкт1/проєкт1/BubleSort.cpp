#include <iostream>
#include <cstdlib>
#include <ctime>

class Sort
{
private:
	int size; //array size
	int* data; //array 

public:
	Sort(int s) //constructor with one parameter
	{
		size = s;
		data = new int[size];
	}

	~Sort() //destructor
	{
		delete[] data;
	}

	void Input()//method for generating random values
	{
		for (int i = 0; i < size; i++)
		{
			data[i] = std::rand() % 10;
		}
	}

	void Print() //method to input an array
	{
		for (int i = 0; i < size; i++)
		{
			std::cout << data[i] << ", ";
		}
	}
	void swap(int& a, int& b) //method for changing array elements by places
	{
		int tmp = a;
		a = b;
		b = tmp;
	}

	void Bublesort() //method of sorting array elements by bubble
	{
		for (int i = 0; i < size - 1; i++)
		{
			bool swapped;

			for (int j = 0; j < size - i - 1; j++) // Go through the unsorted part of the array
			{
				swapped = false;

				if (data[j] > data[j + 1]) // we compare the current element with the next one
				{
					swap(data[j], data[j + 1]); // If the current element is larger than the next one, we swap them
					swapped = true; // Mark that at least one change has occurred
				}
			}

			if (!swapped) // If no change has occurred in this iteration, the array is already sorted
			{
				break;
			}
		}
	}

};

int main()
{
	std::srand(std::time(nullptr)); //to generate random values

	int size; //enter the size of the array
	std::cout << "Enter the size of the array: " << std::endl;
	std::cin >> size;

	Sort sortArray(size);

	sortArray.Input(); //generate random elements
	std::cout << "An unsorted array: " << std::endl;
	sortArray.Print();
	std::cout << std::endl;

	sortArray.Bublesort(); //call the sorting method

	std::cout << "Sorted array: " << std::endl; //output the sorted array
	sortArray.Print();

	system("pause>nul");
	return 0;
}