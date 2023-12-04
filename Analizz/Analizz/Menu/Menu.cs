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
                Title ="╔════════════════════╗\n" +
                       "║       Доход        ║\n" +
                       "╚════════════════════╝",
                Action = TransactionBills.AddIncome
            },
            new MenuOption()
            {
                Title = "╔════════════════════╗\n" +
                        "║       Расход       ║\n" +
                        "╚════════════════════╝",
                Action= TransactionBills.AddExpenses
            },
            new MenuOption()
            {
                Title = "╔════════════════════╗\n" +
                        "║Планирование бюджета║\n" +
                        "╚════════════════════╝",
                Action= BudgetPlanning.SelectBudgetAction

            },
            new MenuOption()
            {
                Title = "╔════════════════════╗\n" +
                        "║  Анализ финансов   ║\n" +
                        "╚════════════════════╝",
                Action = Meneger.SelectAnalysis

            },
            new MenuOption()
            {
                Title = "╔════════════════════╗\n" +
                        "║       Выйти        ║\n" +
                        "╚════════════════════╝\n",
                Action = OnExit,
            },
        };


        public static void OnExit()
        {
            Environment.Exit(0);
        }
    }
}
