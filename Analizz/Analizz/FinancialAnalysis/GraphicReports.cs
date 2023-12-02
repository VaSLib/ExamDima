using Analizz.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizz.FinancialAnalysis
{
    internal class GraphicReports
    {
        List<TransactionOption> income = TransactionBills.GetIncome();              //Лист доходов
        List<TransactionOption> expenses = TransactionBills.GetExpenses();          //Лист расходов
        List<BudgetPlanningOption> incomeBudget = BudgetPlanning.GetIncome();       //Лист запланированных доходов
        List<BudgetPlanningOption> expensesBudget = BudgetPlanning.GetExpenses();   //Лист запланированных расходов

        public static void Print() // Метод вывода Графического отчета 
        {
            Console.Clear();
            Console.WriteLine("Метод вывода Графического отчета");
            Console.ReadKey();

        }
    }
}
