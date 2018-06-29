/* Caesar Cipher */

using System;
using System.Text;

class CaesarCipher
{
    private string alphabet;
    private int length;
    private StringBuilder sb;

    public CaesarCipher()
    {
        alphabet = "abcdefghijklmnopqrstuvwxyz";
        length = alphabet.Length;
    }

    public string Process(string message, int shift, bool encode = false)
    {
        string m = message.ToLower();
        int len = message.Length;
        sb = new StringBuilder();
        int c = 0;

        for(int i = 0; i < len; i++)
        {
            c = alphabet.IndexOf(m[i]);

            if(c > -1)
            {
                c = (encode) ? (c + shift) % length : (c - shift) % length;
                sb.Append(alphabet[c]);
            }

            else
            {
                sb.Append(m[i]);
            }
        }

        return sb.ToString();
    }

	public static void Main()
	{
        string message = "this is just a random message";
        CaesarCipher cc = new CaesarCipher();
        string encoded = cc.Process(message, 4, true);
        string decoded = cc.Process(encoded, 4);
        Console.WriteLine("Original message: " + message);
        Console.WriteLine("Encoded message: " + encoded);
        Console.WriteLine("Decoded message: " + decoded);
    }
}