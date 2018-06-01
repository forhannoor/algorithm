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
		for(int i = 0; i < a.Length; i++)
		{
			Console.Write(a[i] + " ");
		}

		Console.WriteLine();
	}

	public static int [] Sort(int [] a)
	{
		int max = a[0];
		int [] sorted = new int [a.Length];

		for(int i = 1; i < a.Length; i++)
		{
			if(a[i] > max)
			{
				max = a[i];
			}
		}

		int [] count = new int [max + 1];

		for(int i = 0; i < a.Length; i++)
		{
			count[a[i]]++;
		}

		for(int i = 1; i < count.Length; i++)
		{
			count[i] = count[i] + count[i - 1];
		}

		for(int i = 0; i < a.Length; i++)
		{
			int current = a[i];
			int currentCount = count[current];
			count[current]--;
			sorted[currentCount - 1] = current;
		}

		return sorted;
	}
}