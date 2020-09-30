using System;
using System.IO;

namespace SharpXOR
{
    class Program
    {
        public static byte[] XOR(byte [] payload, string XORKey)
        {
           byte[] xorStuff = new byte[payload.Length] ;
           char[] bXORKey = XORKey.ToCharArray();
           for(int i = 0; i< payload.Length;i++)
            {
                xorStuff[i] = (byte)(payload[i] ^ bXORKey[i % bXORKey.Length]);
            }
            return xorStuff;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("absolute path of file to xor");
            String inputPath = Console.ReadLine();
            Console.WriteLine("XOR key ");
            String key = Console.ReadLine();
            Console.WriteLine("absolute path to write output to ");
            String outputPath = Console.ReadLine();
            byte[] payload = File.ReadAllBytes(inputPath);
            byte[] stuff = XOR(payload, key);
            File.WriteAllBytes(outputPath,stuff);
            Console.WriteLine("successfully XOR'd {0}! \n Data written to {1}",inputPath,outputPath);

        }
    }
}
