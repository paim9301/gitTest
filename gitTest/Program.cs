using System;
using System.Security.Cryptography;
using System.Text;

namespace gitTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool VA_MIEUX = true;
            bool NE_VA_PAS_MIEUX = false;

            if (string.IsNullOrEmpty(args[0])) return;
            using (var hash = MD5.Create())
            {
                var arg0Hash = hash.ComputeHash(Encoding.ASCII.GetBytes(args[0]));
                var myTextHash = BitConverter.ToString(arg0Hash).Replace("-", "");
                Console.WriteLine(myTextHash);
            }

            Console.ReadLine();
            Random santeEmilie = new Random();
            var etatEmilie = santeEmilie.Next(0, 1) == 1 ? true : false;
            if (etatEmilie == VA_MIEUX)
            {
                Console.WriteLine(@"Émilie va au cims lundi.");
            }
            else if (etatEmilie.Equals(NE_VA_PAS_MIEUX))
            {
                Console.WriteLine("Les gens du cims seront triste :(.");
            }
            Console.ReadLine();

        }
    }
}