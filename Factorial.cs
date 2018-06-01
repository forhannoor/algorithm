using System;

class Factorial
{
	private uint [] values;
	private int len;

	public Factorial(int size)
	{
		values = new uint [size];
		len = size;
	}

	public void Generate()
	{
		values[0] = 1;

		for(uint i = 1; i < values.Length; i++)
		{
			values[i] = i * values[i - 1];
		}
	}

	public void Print()
	{
		for(int i = 0; i < values.Length; i++)
		{
			Console.Write(values[i] + " ");
		}
	}

	public uint Fac(int n)
	{
		if(n < len)
			return values[n];

		return 0;
	}

	public static void Main()
	{
		Factorial f = new Factorial(20);
		f.Generate();
		uint res = f.Fac(19);
		f.Print();
		uint r = f.GetFactorial(19);
	}

	public uint GetFactorial(uint n)
	{
		if(n < 2)
		{
			return 1;
		}

		return n * GetFactorial(n - 1);
	}
}