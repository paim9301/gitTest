using System;
using System.Security.Cryptography;
using System.Text;

namespace gitTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const bool vaMieux = true;

            #region TEST MD5

            if (string.IsNullOrEmpty(args[0])) return;
            using (var hash = MD5.Create())
            {
                var arg0Hash = hash.ComputeHash(Encoding.ASCII.GetBytes(args[0]));
                var myTextHash = BitConverter.ToString(arg0Hash).Replace("-", "");
                Console.WriteLine(myTextHash);
                Console.ReadLine();
            }

            #endregion

            #region Emilie

            var santeEmilie = new Random();
            var etatEmilie = santeEmilie.Next(100) < 50 ? true : false;
            Console.WriteLine(etatEmilie == vaMieux ? @"Émilie va au cims lundi." : "Les gens du cims seront triste :(.");
            Console.ReadLine();

            #endregion
        }
    }
}