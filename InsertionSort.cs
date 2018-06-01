using System;

class InsertionSort
{
	public static void Main()
	{
		int [] a = new int [] {1, 4, 1, 2, 7, 5, 2};
		Console.WriteLine("Before sort:");
		Print(a);
		Sort(ref a);
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

	public static void Sort(ref int [] a)
	{
		for(int i = 1; i < a.Length; i++)
		{
			int j = i - 1;
			int key = a[i];

			while(j >= 0 && a[j] > key)
			{
				a[j + 1] = a[j];
				j--;
			}

			a[j + 1] = key;
		}
	}
}