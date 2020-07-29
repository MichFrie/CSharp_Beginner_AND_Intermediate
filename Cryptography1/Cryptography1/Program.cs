using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Cryptography1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"d:\C# console\Cryptography1\FirstFile.txt";
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"d:\C# console\Cryptography1\SecondFile.txt";

            RijndaelManaged encryption = new RijndaelManaged();

            using (FileStream filestream = new FileStream(path2,FileMode.Open))
            {
                using (CryptoStream stream = new CryptoStream(filestream, encryption.CreateEncryptor(encryption.Key,encryption.IV), CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        using (StreamReader reader = new StreamReader(new FileStream(path1,FileMode.Open)))
                        {
                            string content = reader.ReadToEnd();
                            writer.Write(content);
                        }
                    }
                }
            }
            Console.WriteLine("Encryption is done!");

            using (FileStream filestream = new FileStream(path2, FileMode.Open))
            {
                using (CryptoStream stream = new CryptoStream(filestream, encryption.CreateDecryptor(encryption.Key, encryption.IV), CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string content = reader.ReadToEnd();
                        Console.WriteLine(content);
                    }
                }
            }
            Console.WriteLine("Decryption is done!");

            Console.ReadKey();
        }
    }
}
