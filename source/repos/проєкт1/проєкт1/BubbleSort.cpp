#include <iostream>

class Sort
{
private:
	int size;
	int* data;

public:

	Sort(int s)
	{
		size = s;
		data = new int[size];
	}

	~Sort()
	{
		delete[] data;
	}

	void Input()
	{
		for (int i = 0; i < size; i++)
		{
			std::cout << "¬вед≥ть елемент " << i+1 << " масиву: " << std::endl;
			std::cin >> data[i];
		}
	}

	void MergeSort( int low, int high)
	{
		if (low < high)
		{
			int mid = (low + high) / 2;

			MergeSort(low, mid);
			MergeSort(mid + 1, high);

			Merge(low, mid, high);
		}
	}

	void Merge(int low, int mid, int high)
	{
		int n1 = mid - low + 1;
		int n2 = high - mid;

		int* LeftArray = new int [n1];
		int* RightArray= new int [n2];

		for (int i = 0; i < n1; i++)
		{
			LeftArray[i] = data[low + i];
		}

		for (int j = 0; j < n2; j++)
		{                                                                                                                                                                              
			RightArray[j] = data[mid + 1 + j];
		}

		int i = 0;
		int j = 0;
		int k = low;

		while (i < n1 && j < n2)
		{
			if (LeftArray[i] <= RightArray[j])
			{
				data[k] = LeftArray[i];
				i++;
			}
			else
			{
				data[k] = RightArray[j];
				j++;
			}
			k++;
		}

		while (i < n1)
		{
			data[k] = LeftArray[i];
			i++;
			k++;
		}

		while (j < n2)
		{
			data[k] = RightArray[j];
			j++;
			k++;
		}

		delete[] LeftArray;
		delete[] RightArray;
	}

	void Print()
	{
		std::cout << "в≥дсортований масив: " << std::endl;
		for (int i = 0; i < size; i++)
		{
			std::cout << data[i] << ", ";
		}
	}

};

int main()
{
	system("chcp 1251");

	int size;
	std::cout << "введ≥ть розм≥р масиву: ";
	std::cin >> size;

	Sort arraysort(size);
	arraysort.Input();

	arraysort.MergeSort( 0, size - 1);
	
	arraysort.Print();

	system("pause>nul");
	return 0;
}