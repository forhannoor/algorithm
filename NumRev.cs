using System;

class NumRev
{
	public static void Main()
	{
		string num = Console.ReadLine();
		ulong a = ulong.Parse(num);
		ulong b = 0, r = 0;
		ulong pow = (ulong) num.Length - 1;

		while(a != 0)
		{
			r = a % 10;
			a /= 10;
			b = b + (r * Power(10, pow--));
		}

		Console.WriteLine($"Number in reverse: {b}");
	}

	public static ulong Power(ulong b, ulong p)
	{
		ulong r = 1;

		if(b == 2)
		{
			r = b << (int) (p - 1);
		}

		else
		{
			for(ulong i = 0; i < p; ++i)
			{
				r *= b;
			}
		}
	
		return r;
	}
}