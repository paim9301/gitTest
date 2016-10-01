using System;
using System.Security.Cryptography;
using System.Text;

namespace gitTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(args[0])) return;
            using (var hash = MD5.Create())
            {
                var arg0Hash = hash.ComputeHash(Encoding.ASCII.GetBytes(args[0]));
                var myTextHash = BitConverter.ToString(arg0Hash).Replace("-", "");
                Console.WriteLine(myTextHash);
            }
            Console.ReadLine();
        }
    }
}