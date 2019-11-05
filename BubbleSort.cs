using System;

class BubbleSort
{
	public static void Main()
	{
		int [] numbers = new int [] {5, 6, 9, 3, 2, 4, 1};
		Console.WriteLine("Before sort:");
		Print(numbers);
		Sort(ref numbers);
		Console.WriteLine("After sort:");
		Print(numbers);
	}

	public static void Print(int [] numbers)
	{
		int length = numbers.Length;

		for(int i = 0; i < length; ++i)
		{
			Console.Write($"{numbers[i]} ");
		}

		Console.WriteLine();
	}

	public static void Sort(ref int [] numbers)
	{
		int swapCount = 1, limit, temp;

		while(swapCount > 0)
		{
			swapCount = 0;
			limit = numbers.Length - 1;

			for(int i = 0; i < limit; ++i)
			{
				if(numbers[i] > numbers[i + 1])
				{
					temp = numbers[i + 1];
					numbers[i + 1] = numbers[i];
					numbers[i] = temp;
					swapCount++;
				}
			}
		}
	}
}