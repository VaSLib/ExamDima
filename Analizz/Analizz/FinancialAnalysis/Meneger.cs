using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizz.FinancialAnalysis
{
    internal class Meneger
    {
        public static void SelectAnalysis() // Выбор действия бюджета
        {
            // Примерный вывод. Желательно изменить интерфейс


            Console.Clear();
            ConsoleKeyInfo keyInfo;
            int number = 0;

            Console.WriteLine("1-Финансовый анализ \n2-Графический отчет ");

            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                FinancialAnalysis.Print();
            }
            else if (number == 2)
            {
                GraphicReports.Print();
            }
            else 
            {
                SelectAnalysis();
            }
        }
    }
}
