/* Converts between number bases */

using System;
using System.Text;

class Converter
{
    private char[] misc;
    private StringBuilder sb;
    
    public Converter()
    {
        misc = new char[36];
        int i = 0;

        for(char c = '0'; c <= '9'; c++)
        {
            misc[i++] = c;
        }

        for(char c = 'A'; c <= 'Z'; c++)
        {
            misc[i++] = c;
        }
    }

    public int IndexOf(char c)
    {
        int r = -1;
        int len = misc.Length;

        for(int i = 0; i < len; i++)
        {
            if(misc[i] == c)
            {
                r = i;
                break;
            }
        }

        return r;
    }

	public int ToDecimal(string num, int b)
    {
        int r = 0, val = 0;
        int len = num.Length;

        for(int i = 0; i < len; i++)
        {
            val = IndexOf(num[i]);
            r = r + (val * (int) Math.Pow(b, len - i - 1));
        }

        return r;
    }

    public string ToBase(int num, int b)
    {
        sb = new StringBuilder();
        int rem;

        while(num != 0)
        {
            rem = num % b;
            num /= b;
            sb.Insert(0, misc[rem]);
        }

        return sb.ToString();
    }

	public static void Main()
	{
        Converter c = new Converter();
        string inp;
        int b, t, deci = 0;
        Console.WriteLine("******************************************");
        Console.WriteLine("*** This program converts number bases ***");
        Console.WriteLine("******************************************");

        while (true)
        {
            Console.WriteLine("Number: ");
            inp = Console.ReadLine();
            Console.WriteLine("Current Base: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Target Base: ");
            t = int.Parse(Console.ReadLine());
            deci = (b == 10) ? int.Parse(inp) : c.ToDecimal(inp, b);
            Console.WriteLine("Output: " + c.ToBase(deci, t));
        }
    }
}