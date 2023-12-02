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




        public static void AddIncome() // Метод добавление дохода
        {
            Console.Clear();
            Console.WriteLine("Метод добавление дохода");
            Console.ReadKey();

        }

        public static void AddExpenses() // Метод добавление расхода
        {
            Console.Clear();
            Console.WriteLine("Метод добавление расхода");
            Console.ReadKey();

        }

        
    }
}
