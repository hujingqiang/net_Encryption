using System;
using com.pakhee.common;

namespace testConsole20170619
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Hello World!");
			Console.WriteLine("Hello World again!");

			CryptLib _crypt = new CryptLib();
			string plainText = "This is the text to be encrypted.";
            String iv = "4NAfcTL5nWERGSLl";//CryptLib.GenerateRandomIV(16); //16 bytes = 128 bits
			string key = CryptLib.getHashSha256("my secret key", 32); //32 bytes = 256 bits
			String cypherText = _crypt.encrypt(plainText, key, iv);
			Console.WriteLine("isv=" + iv);
			Console.WriteLine("key=" + key);
			Console.WriteLine("Cypher text=" + cypherText);
			Console.WriteLine("Plain text =" + _crypt.decrypt(cypherText, key, iv));
        }
    }
}
