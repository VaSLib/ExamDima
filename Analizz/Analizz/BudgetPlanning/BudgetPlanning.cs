using Analizz.Menu;
using Analizz.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizz.Option
{
    internal class BudgetPlanning
    {
        public static List<BudgetPlanningOption> income = new List<BudgetPlanningOption>(); // Лист запланированных доходов
        public static List<BudgetPlanningOption> expenses = new List<BudgetPlanningOption>(); // Лист запланированных расходов
        public static List<BudgetPlanningOption> GetIncome() => income; // Метод запланированных доходов ->для АдилБайке
        public static List<BudgetPlanningOption> GetExpenses() => expenses;// Метод запланированных расходов ->для АдилБайке 

        public static void SelectBudgetAction() // Выбор действия бюджета
        {
            // Примерный вывод. Желательно изменить интерфейс


            Console.Clear();
            ConsoleKeyInfo keyInfo;
            int? number = 0;

            Console.WriteLine("1-Планирование дохода \n2-Планирование расхода \n3-Удаление запланированного Бюджета");

            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                AddIncome();
            }
            else if (number == 2)
            {
                AddExpenses();
            }
            else if (number == 3)
            {
                RemoveBudget();
            }
            else
            {
                SelectBudgetAction();
            }
        }

        public static void AddIncome() // Метод добавление запланированного дохода 
        {
            Console.Clear();
            Console.WriteLine("Метод добавление запланированного дохода");
            Console.ReadKey();

        }

        public static void AddExpenses() // Метод добавление запланированного расхода
        {
            Console.Clear();
            Console.WriteLine("Метод добавление запланированного расхода");
            Console.ReadKey();
        }
        public static void RemoveBudget() // Метод удаления запланированного Бюджета
        {
            Console.Clear();
            Console.WriteLine("Метод удаления запланированного Бюджета");
            Console.ReadKey();
        }

    }
}
