using System;

struct Node
{
	public int data;
	public bool marked;
	public int index;

	public Node(int d)
	{
		data = d;
		marked = false;
		index = -1;
	}
}

class Sieve
{
	private int _numbers;
	private Node [] _table;

	public Sieve(int n)
	{
		_numbers = n;
		_table = new Node [n - 1];
		int start = 2;

		for(int i = 0; i < n - 1; ++i)
		{
			Node temp = new Node(start++);
			temp.index = i;
			_table[i] = temp;
		}
	}

	public void PrintPrimes()
	{
		for(int i = 0; i < _numbers - 1; ++i)
		{
			if(! _table[i].marked)
			{
				Console.Write($"{_table[i].data} ");
			}
		}

		Console.WriteLine();
	}

	public void Process()
	{
		Node t = new Node(-1);
		Node temp;
		t = GetFirstUnmarked(t);

		while(t.data != -1)
		{
			for(int i = t.index + 1; i < _numbers - 1; ++i)
			{
				temp = _table[i];

				if(! temp.marked && temp.data % t.data == 0)
				{
					temp.marked = true;
					_table[i] = temp;
				}
			}

			t = GetFirstUnmarked(t);
		}
	}

	public Node GetFirstUnmarked(Node last)
	{
		Node n = new Node(-1);
		
		for(int i = last.index + 1; i < _numbers - 1; ++i)
		{
			if(! _table[i].marked)
			{
				n = _table[i];
				break;
			}
		}

		return n;
	}

	public static void Main()
	{
		Console.Write("Input a number up to which you want to see the prime nunbers:");
		int n = int.Parse(Console.ReadLine());
		Sieve s = new Sieve(n);
		s.Process();
		s.PrintPrimes();
	}
}