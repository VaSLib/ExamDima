using Analizz.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analizz.Option;

namespace Analizz.Option
{
    internal class TransactionBills
    {
        public static List<TransactionOption> income = new List<TransactionOption>(); // Лист доходов
        public static List<TransactionOption> expenses = new List<TransactionOption>(); // Лист расходов
        public static List<TransactionOption> GetIncome() => income; // Метод получения доход ->для АдилБайке
        public static List<TransactionOption> GetExpenses() => expenses;// Метод получения расхода ->для АдилБайке 




        public static void AddIncome()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════╗\n" +
                              "║ Введите категорию дохода: ║\n" +
                              "╚═══════════════════════════╝\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? category = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine(" ");


            decimal amount;
            while (true)
            {
                Console.WriteLine("╔═══════════════════════════╗\n" +
                                  "║   Введите сумму дохода:   ║\n" +
                                  "╚═══════════════════════════╝\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string? amountInput = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine(" ");

                if (decimal.TryParse(amountInput, out amount))
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение!");
                Console.ResetColor();
            }


            TransactionOption incomeItem = new TransactionOption()
            {
                Date = DateTime.Now,
                Description = category,
                Amount = amount
            };

            income.Add(incomeItem);
            Console.WriteLine("Доход успешно добавлен.");
            foreach (TransactionOption item in income)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Дата: {item.Date} \nКатегория: {item.Description} \nСумма: {item.Amount} сом");
                Console.ResetColor();
            }
            Console.WriteLine("\nЧтобы вернуться назад нажмите на Enter");

            Console.ReadLine();

        }

        public static void AddExpenses()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════╗\n" +
                              "║ Введите категорию расхода: ║\n" +
                              "╚════════════════════════════╝\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? category = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine(" ");

            decimal amount;
            while (true)
            {
                Console.WriteLine("╔════════════════════════════╗\n" +
                                  "║   Введите сумму расхода:   ║\n" +
                                  "╚════════════════════════════╝\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string? amountInput = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine(" ");

                if (decimal.TryParse(amountInput, out amount))
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение!");
                Console.ResetColor();
            }


            TransactionOption expenseItem = new TransactionOption()
            {
                Date = DateTime.Now,
                Description = category,
                Amount = amount
            };

            expenses.Add(expenseItem);
            Console.WriteLine("Расход успешно добавлен.");
            foreach (TransactionOption item in expenses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Дата: {item.Date} \nКатегория: {item.Description} \nСумма: {item.Amount} сом");
                Console.ResetColor();

            }
            Console.WriteLine("\nЧтобы вернуться назад нажмите на Enter");

            Console.ReadLine();


        }
    }
}
