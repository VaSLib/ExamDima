using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Analizz.Menu;
using Analizz.Option;
using Analizz.FinancialAnalysis;

namespace Analizz.Menu
{
    internal class MenuHelper
    {



        public static void ShowMenu()
        {
            ConsoleKeyInfo keyInfo;
            List<MenuOption> options = Menu.options;
            int number = 0;
            

            do
            {
                PrintFirst("Главная");
                
              

                for (int NumberCinema = 0; NumberCinema < options.Count; NumberCinema++)
                {
                    
                    if (NumberCinema == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(options[NumberCinema].Title);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + options.Count()) % options.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % options.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options[number].Action();  
                }

            } while (keyInfo.Key != ConsoleKey.Escape);



        }

        


       
        public static void PrintFirst(string? name)
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "╔════════════════════╗");
            Console.WriteLine($"║       { name}      ║");
            Console.WriteLine( "╚════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Баланс:" + Balance.showCurrentBalance());
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }


    }
}
