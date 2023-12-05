using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analizz.Option;

using Analizz.Option;
namespace Analizz.FinancialAnalysis
{
    internal class FinancialAnalysis
    {
        List<TransactionOption> income = TransactionBills.GetIncome();              //Лист доходов
        List<TransactionOption> expenses = TransactionBills.GetExpenses();          //Лист расходов
        List<BudgetPlanningOption> incomeBudget = BudgetPlanning.GetIncome();       //Лист запланированных доходов
        List<BudgetPlanningOption> expensesBudget = BudgetPlanning.GetExpenses();   //Лист запланированных расходов

        public static void Print() // Метод добавление запланированного дохода 
        {
            Console.Clear();
            Console.WriteLine("Метод вывода финансового анализа");
            Console.ReadKey();

        }



    }
}
