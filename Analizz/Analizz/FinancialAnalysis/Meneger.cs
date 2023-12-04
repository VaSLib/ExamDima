using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Analizz.FinancialAnalysis
{
    internal class Meneger
    {
        public static void SelectAnalysis() // Выбор действия бюджета
        {
            // Примерный вывод. Желательно изменить интерфейс


            Console.Clear();
            ConsoleKeyInfo keyInfo;
            int? number = 0;

            List<string> Analysis = new List<string>() { "╔════════════════════╗\n" +
                                                         "║ Финансовый анализ  ║\n"+
                                                         "╚════════════════════╝"
                                                       , "╔════════════════════╗\n" +
                                                         "║ Графический отчет  ║\n" +
                                                         "╚════════════════════╝" };


            do
            {
                Console.Clear() ;
                Console.WriteLine("Выбор отчета:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine( "╔════════════════════╗");
                Console.WriteLine($"║    Выбор отчета:   ║");
                Console.WriteLine( "╚════════════════════╝\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;



                for (int NumberCinema = 0; NumberCinema < Analysis.Count; NumberCinema++)
                {

                    if (NumberCinema == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(Analysis[NumberCinema]);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + Analysis.Count()) % Analysis.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % Analysis.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter && number ==0)
                {
                    FinancialAnalysis.Print();
                }
                if (keyInfo.Key == ConsoleKey.Enter && number == 1)
                {
                    GraphicReports.Print();
                }
                

            } while (keyInfo.Key != ConsoleKey.Escape);



          
        }
    }
}
