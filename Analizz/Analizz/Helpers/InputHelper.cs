using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizz.Menu
{
    internal class InputHelper
    {
        public static string ReadString(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            string? value = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            Console.WriteLine("Please try again");
            return ReadString(inputMessage);
        }

        public static int ReadNumber(string inputMessage)
        {
            string value = ReadString(inputMessage);
            if (int.TryParse(value, out int number))
            {
                return number;
            }

            Console.WriteLine("Input number using digits");
            return ReadNumber(inputMessage);
        }
    }
}
