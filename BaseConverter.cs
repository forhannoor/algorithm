using System;
using System.Text;
using System.Collections.Generic;

class BaseConverter
{
	private int _decimal;
	private string _binary;

	public string DecimalToBinary(int i = -1, int size = 0)
	{
		var s = new StringBuilder();
		var stack = new Stack<int>();
		int r = 0;

		if(i < 0)
		{
			i = _decimal;
		}

		if(i == 0)
		{
			return "0000000000";
		}
		
		while(i != 0)
		{
			r = i % 2;
			stack.Push(r);
			i = i >> 1;
		}

		int count = stack.Count;
		
		while(count > 0)
		{
			r = stack.Pop();
			s.Append(r);
			--count;
		}

		int padding = (s.Length >= size) ? 0 : Math.Abs(s.Length - size);
		
		if(size > 0)
		{
			for(int j = 0; j < padding; ++j)
			{
				s.Insert(0, "0");
			}
		}
		
		return s.ToString();
	}

	public int BinaryToDecimal(string b = "")
	{
		if(b.Length == 0)
		{
			if(_binary.Length == 0)
			{
				return 0;
			}

			b = _binary;
		}

		int d = 0;
		int len = b.Length;
		int pow = len - 1;

		for(int i = 0; i < len; ++i)
		{
			int t = (int) b[i] - 48;
			d = d + t * Power(2, pow--);
		}

		return d;
	}

	public int Power(int b, int p)
	{
		int r = 1;

		if(b == 2 && p > 1)
		{
			r = b << (int) (p - 1);
		}

		else
		{
			for(int i = 0; i < p; ++i)
			{
				r *= b;
			}
		}
	
		return r;
	}

	public static void Main()
	{
		BaseConverter bc = new BaseConverter();
		string b;
		
		for(int i = 0; i < 500; i++)
		{
			b = bc.DecimalToBinary(i, 10);
			Console.WriteLine($"{bc.BinaryToDecimal(b)}---------->{b}");
		}
	}
}