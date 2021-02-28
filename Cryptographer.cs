using System;
using System.Linq;
using System.Text;

public class Cryptography
{
    private byte[] Keys { get; set; }


    public Cryptography(string password)
    {
        Keys = Encoding.ASCII.GetBytes(password);
    }

    public byte[] Decrypt(byte[] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = (byte)(Keys[i % Keys.Length] ^ data[i]);
        }
        return data.ToArray<byte>();
    }
}

public static class Xor
{
    public static string FromHexString(string hexString)
    {
        byte[] array = new byte[hexString.Length / 2];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
        }
        return Encoding.Unicode.GetString(array);
    }
    public static string DXorString(string text, string key)
    {
        text = FromHexString(text);
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            result.Append((char)(text[i] ^ (uint)key[i % key.Length]));
        }
        return result.ToString();
    }

}

