using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Analizz.Menu;
using Analizz.Option;

using Analizz.Option;

namespace Analizz.FinancialAnalysis;

internal class FinancialAnalysis
{
     static List<TransactionOption> income = TransactionBills.GetIncome();              //Лист доходов
     static List<TransactionOption> expenses = TransactionBills.GetExpenses();          //Лист расходов
     static List<BudgetPlanningOption> incomeBudget = BudgetPlanning.GetIncome();       //Лист запланированных доходов
     static List<BudgetPlanningOption> expensesBudget = BudgetPlanning.GetExpenses();   //Лист запланированных расходов

    public static void Print() // Метод добавление запланированного дохода 
    {
        Console.Clear();
        Console.WriteLine("Метод вывода финансового анализа");

        showFinancialAnalysisMenu();
        
    }

    private const int Показать_доход = 1;
    private const int Показать_расход = 2;
    private const int Показать_планновый_доход = 3;
    private const int Показать_планновый_расход = 4;
    private const int Назад = 5;




   


    public static void showFinancialAnalysisMenu()
    {
        Console.WriteLine("Вы находитесь в разделе Анализ Финансов");
        Console.WriteLine($"{Показать_доход} - Показать доход");
        Console.WriteLine($"{Показать_расход} - Показать расход");
        Console.WriteLine($"{Показать_планновый_доход} - Показать планновый доход");
        Console.WriteLine($"{Показать_планновый_расход} - Показать Расход");
        Console.WriteLine($"{Назад} - Назад ");
        Console.WriteLine();
        int operationId = InputHelper.ReadNumber("Выберите команду: ");

        ProcessOperation(operationId);

    }

    private static void ProcessOperation(int operationId)
    {
        if (operationId == 1)
        {
            PrintTransactions(income, "пришло");
        }
        else if (operationId == 2)
        {
            PrintTransactions(expenses, "ушло");
        }
        else if (operationId == 3)
        {
            PrintBudgetTransactions(incomeBudget);
        }
        else if (operationId == 4)
        {
            PrintBudgetTransactions(expensesBudget);
        }
        else if (operationId == 5)
        {
            Meneger.SelectAnalysis();
        }
        else
        {
            Console.WriteLine("please enter commands mentioned here");
        }
        Console.ReadKey();
        Console.Clear();
        showFinancialAnalysisMenu();
       
        /* switch (operationId)
         {
             case Показать_доход:
                 PrintTransactions(income);
                 break;
             case Показать_расход :
                 PrintTransactions(expenses);
                 break;
             case Показать_планновый_доход:
                 PrintBudgetTransactions(incomeBudget);
                 break;
             case Показать_планновый_расход:
                 PrintBudgetTransactions(expensesBudget);
                 break;
             case Назад:
                 Meneger.SelectAnalysis();
                 break;
         }*/
    }


    static void PrintTransactions(List<TransactionOption> transactions, string message)
    {
        var total = transactions.Sum(item => item.Amount);
        foreach (var transaction in transactions)
        {
            Console.WriteLine($"На {transaction.Description} {message} {transaction.Amount} в {transaction.Date}");
            Console.WriteLine();
        }
        Console.WriteLine($"Всего: {total} на этот месяц");
    }
    static void PrintBudgetTransactions(List<BudgetPlanningOption> transactions)
    {
        var total = transactions.Sum(item => item.Amount);
        foreach (var transaction in transactions)
        {
            
            Console.WriteLine($"{transaction.Description}, {transaction.Amount}");
            Console.WriteLine();
        }
        Console.WriteLine($"Всего: {total} на этот месяц");
    }
    

    
}