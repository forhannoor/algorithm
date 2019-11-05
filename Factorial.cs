using System;

class Factorial
{
	private uint [] _precomputedValues;
	private int _numPrecomputedValues;

	public Factorial(int size)
	{
		_precomputedValues = new uint [size];
		_numPrecomputedValues = size;
	}

	public void Generate()
	{
		_precomputedValues[0] = 1;

		for(uint i = 1; i < _numPrecomputedValues; ++i)
		{
			_precomputedValues[i] = i * _precomputedValues[i - 1];
		}
	}

	public void Print()
	{
		for(int i = 0; i < _numPrecomputedValues; ++i)
		{
			Console.Write($"{_precomputedValues[i]}");
		}
	}

	public uint Fac(int n)
	{
		uint result = 0;

		if(n < _numPrecomputedValues)
		{
			result = _precomputedValues[n];
		}

		return result;
	}

	public static void Main()
	{
		Factorial f = new Factorial(20);
		f.Generate();
		f.Print();
	}
}