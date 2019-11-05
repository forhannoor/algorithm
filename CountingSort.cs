using System;

class CountingSort
{
	public static void Main()
	{
		int [] a = new int [] {1, 4, 1, 2, 7, 5, 2};
		Console.WriteLine("Before sort:");
		Print(a);
		a = Sort(a);
		Console.WriteLine("After sort:");
		Print(a);
	}

	public static void Print(int [] a)
	{
		int length = a.Length;
		
		for(int i = 0; i < length; ++i)
		{
			Console.Write($"{a[i]} ");
		}

		Console.WriteLine();
	}

	public static int [] Sort(int [] a)
	{
		int max = a[0], length = a.Length;
		var sorted = new int [a.Length];

		for(int i = 1; i < length; ++i)
		{
			if(a[i] > max)
			{
				max = a[i];
			}
		}

		var count = new int [max + 1];

		for(int i = 0; i < length; ++i)
		{
			count[a[i]] += 1;
		}

		int countLength = count.Length;
		int current, currentCount;

		for(int i = 1; i < countLength; ++i)
		{
			count[i] = count[i] + count[i - 1];
		}

		for(int i = 0; i < length; ++i)
		{
			current = a[i];
			currentCount = count[current];
			count[current] -= 1;
			sorted[currentCount - 1] = current;
		}

		return sorted;
	}
}