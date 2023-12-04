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

            Console.WriteLine("Введите категорию дохода:");
            string? category = Console.ReadLine();

            Console.WriteLine("Введите сумму дохода:");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            TransactionOption incomeItem = new TransactionOption()
            {
                Date = DateTime.Now,
                Description = category,
                Amount = amount
            };

            income.Add(incomeItem);


            Console.ReadLine();

        }

        public static void AddExpenses()
        {
            Console.Clear();
            Console.WriteLine("Введите категорию расхода:");
            string? category = Console.ReadLine();

            Console.WriteLine("Введите сумму расхода:");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            TransactionOption expenseItem = new TransactionOption()
            {
                Date = DateTime.Now,
                Description = category,
                Amount = amount
            };

            expenses.Add(expenseItem);

            Console.ReadLine();

        }
    }
}
