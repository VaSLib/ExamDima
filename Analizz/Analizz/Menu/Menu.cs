using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analizz.Option;
using Analizz.FinancialAnalysis;

namespace Analizz.Menu
{
    internal class Menu
    {


        public static void Start()
        {

            MenuHelper.ShowMenu();

        }

        


        public static List<MenuOption> options = new List<MenuOption>()
        {

            new MenuOption()
            {
                Title = "Доход",
                Action = TransactionBills.AddIncome
            },
            new MenuOption()
            {
                Title = "Расход",
                Action= TransactionBills.AddExpenses
            },
            new MenuOption()
            {
                Title = "Планирования бюджета",
                Action= BudgetPlanning.SelectBudgetAction

            },
            new MenuOption()
            {
                Title = "Анализа финансов",
                Action = Meneger.SelectAnalysis

            },
            new MenuOption()
            {
                Title = "Выйти",
                Action = OnExit,
            },
        };


        public static void OnExit()
        {
            Environment.Exit(0);
        }
    }
}
