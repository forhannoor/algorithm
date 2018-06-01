using System;

class BubbleSort
{
	public static void Main()
	{
		int [] a = new int [] {5, 6, 9, 3, 2, 4, 1};
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
		int swapCount = 1;

		while(swapCount > 0)
		{
			swapCount = 0;

			for(int i = 0; i < a.Length - 1; i++)
			{
				if(a[i] > a[i + 1])
				{
					int temp = a[i + 1];
					a[i + 1] = a[i];
					a[i] = temp;
					swapCount++;
				}
			}
		}
	}
}