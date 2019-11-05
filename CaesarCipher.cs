using System;
using System.Text;

class CaesarCipher
{
    private StringBuilder _stringBuilder;
    private const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
    
    public CaesarCipher()
    {
        _stringBuilder = new StringBuilder();
    }

    public string Process(string message, int shift, bool encode = false)
    {
        string m = message.ToLower();
        int messageLength = message.Length;
        int c = 0;
        int length = ALPHABET.Length;
        _stringBuilder.Clear();

        for(int i = 0; i < messageLength; ++i)
        {
            c = ALPHABET.IndexOf(m[i]);

            if(c > -1)
            {
                c = (encode) ? (c + shift) % length : (c - shift) % length;
                _stringBuilder.Append(ALPHABET[c]);
            }

            else
            {
                _stringBuilder.Append(m[i]);
            }
        }

        return _stringBuilder.ToString();
    }

	public static void Main()
	{
        string message = "this is just a random message";
        CaesarCipher cc = new CaesarCipher();
        string encoded = cc.Process(message, 4, true);
        string decoded = cc.Process(encoded, 4);
        Console.WriteLine($"Original message: {message}");
        Console.WriteLine($"Encoded message: {encoded}");
        Console.WriteLine($"Decoded message: {decoded}");
    }
}