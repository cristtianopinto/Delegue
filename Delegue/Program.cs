using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegue
{
    class Program
    {
        public delegate void monDelegate(string message);
        static void Main(string[] args)
        {
            var instDelegue = new monDelegate(AfficherMessage);
            instDelegue += AfficherMessageError;
            TesteDelegue(" ", " ", instDelegue);
        }
        public static void TesteDelegue(
            string a,
            string b,
            monDelegate methodePourAfficher)
        {
            methodePourAfficher("VOILA!");
            
        }

        public static void AfficherMessage(string message)
        {
            Console.WriteLine($"Voila {message}");
        }
        public static void AfficherMessageError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Voila {message}");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
