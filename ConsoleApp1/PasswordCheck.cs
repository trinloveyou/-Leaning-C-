using System;
using System.Linq;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            Console.WriteLine("EnterPass:");
            string password = Console.ReadLine();
            bool containsAtLeastOneUppercase = password.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = password.Any(char.IsLower);
            bool containsAtLeastOneSpecialChar = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool containsAtLeastOneDigit = password.Any(char.IsDigit);
            int score = 0;
            if (password.Length >= minLength)
            {
                score++;
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("false");
            }
            if (containsAtLeastOneUppercase)
            {
                score++;
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("false");
            }
            if (containsAtLeastOneLowercase)
            {
                score++;
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("false");
            }
            if (containsAtLeastOneDigit)
            {
                score++;
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("false");
            }
            if (containsAtLeastOneSpecialChar)
            {
                score++;
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("false");
            }
        }
    }
}
