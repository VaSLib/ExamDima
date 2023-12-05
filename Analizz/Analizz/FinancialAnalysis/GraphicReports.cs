using Analizz.Option;
using System;
using System.Collections.Generic;

namespace Analizz.FinancialAnalysis
{
    internal class GraphicReports
    {
        public static List<TransactionOption> income = TransactionBills.GetIncome();              //Лист доходов
        public static List<TransactionOption> expenses = TransactionBills.GetExpenses();          //Лист расходов
        public static List<BudgetPlanningOption> incomeBudget = BudgetPlanning.GetIncome();       //Лист запланированных доходов
        public static List<BudgetPlanningOption> expensesBudget = BudgetPlanning.GetExpenses();   //Лист запланированных расходов


        public static void Print()
        {
            Console.Clear();
            Console.WriteLine("Метод вывода Графического отчета");

            decimal resultIncome = PrintTransactions("Доходы:", income);
            decimal resultExpenses = PrintTransactions("Расходы:", expenses);
            decimal resultIncomeBudget = PrintBudget("Лист запланированных доходов:", incomeBudget);
            decimal resultExpensesBudget = PrintBudget("Лист запланированных расходов:", expensesBudget);

            Console.WriteLine("\nИтоговый доход: " + resultIncome);
            Console.WriteLine("Итоговый расход: " + resultExpenses);
            Console.WriteLine("Баланс: " + (resultIncome - resultExpenses));

            Console.WriteLine("\nИтоговый запланированный доход: " + resultIncomeBudget);
            Console.WriteLine("Итоговый запланированный расход: " + resultExpensesBudget);


            PrintBarChart("Расходы", expenses);
            PrintBarChart("Лист запланированных расходов", expensesBudget);

            Console.ReadKey();
        }

        public static decimal PrintTransactions(string header, List<TransactionOption> transactions)
        {
            Console.WriteLine(header);
            decimal result = 0;
            foreach (var item in transactions)
            {
                Console.WriteLine($"Description: {item.Description}, Amount: {item.Amount}");
                result += item.Amount;
            }
            return result;
        }

        public static decimal PrintBudget(string header, List<BudgetPlanningOption> budget)
        {
            Console.WriteLine(header);
            decimal result = 0;
            foreach (var item in budget)
            {
                Console.WriteLine($"Description: {item.Description}, Amount: {item.Amount}");
                result += item.Amount;
            }
            return result;
        }
        private static void PrintBarChart(string header, List<TransactionOption> transactions)
        {
            Console.WriteLine(header + " (Bar Chart):");
            foreach (var item in transactions)
            {
                Console.Write($"{item.Description}: ");
                PrintGraphBarChart(item.Amount);
            }
            Console.WriteLine();
        }

        private static void PrintBarChart(string header, List<BudgetPlanningOption> budget)
        {
            Console.WriteLine(header + " (Bar Chart):");
            foreach (var item in budget)
            {
                Console.Write($"{item.Description}: ");
                PrintGraphBarChart(item.Amount);
            }
            Console.WriteLine();
        }

        private static void PrintGraphBarChart(decimal amount)
        {

            int barLength = (int)amount / 100;
            Console.WriteLine(new string('☼', barLength));
        }
    }
}