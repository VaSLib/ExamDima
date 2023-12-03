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
        private static List<string> titles = new List<string> { "Планирование дохода", "Планирование расхода", "Удаление запланированного Бюджета" };
        private static List<string> titlesRemove = new List<string> { "Удаление дохода", "Удаление расхода" };
        public static List<BudgetPlanningOption> income = new List<BudgetPlanningOption>(); // Лист запланированных доходов
        public static List<BudgetPlanningOption> expenses = new List<BudgetPlanningOption>(); // Лист запланированных расходов
        public static List<BudgetPlanningOption> GetIncome() => income; // Метод запланированных доходов ->для АдилБайке
        public static List<BudgetPlanningOption> GetExpenses() => expenses;// Метод запланированных расходов ->для АдилБайке 

        public static void SelectBudgetAction() // Выбор действия бюджета
        {

            ConsoleKeyInfo keyInfo;
            int number = 0;

            do
            {
                Console.Clear();

                for (int NumberCinema = 0; NumberCinema < titles.Count; NumberCinema++)
                {
                    if (NumberCinema == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(titles[NumberCinema]);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + titles.Count()) % titles.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % titles.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (number == 0)
                        AddIncome();
                    else if (number == 1)
                        AddExpenses();
                    else if (number == 2)
                        RemoveBudget();
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        public static void AddIncome() // Метод добавление запланированного дохода 
        {
            Console.Clear();

            Console.WriteLine("Добавление дохода");
            Console.WriteLine("Введите сумму дохода: ");
            decimal sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите описание: ");
            string input = Console.ReadLine();

            BudgetPlanningOption budget = new BudgetPlanningOption();
            budget.Amount = sum;
            budget.Description = input;
            income.Add(budget);
            Console.WriteLine("Данные успешно сохранены");
            Console.WriteLine($"Нажмите Enter чтобы продолжить или Escape для выхода");

            var keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
                return;
            else if (keyInfo.Key == ConsoleKey.Enter)
                AddIncome();
        }
        public static void AddExpenses() // Добавление запланированного расхода
        {
            Console.Clear();

            Console.WriteLine("Добавление запланированного расхода");
            Console.WriteLine("Введите сумму расхода: ");
            decimal sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите описание: ");
            string input = Console.ReadLine();

            BudgetPlanningOption budget = new BudgetPlanningOption();
            budget.Amount = sum;
            budget.Description = input;
            expenses.Add(budget);
            Console.WriteLine("Данные успешно сохранены");
            Console.WriteLine($"Нажмите Enter чтобы продолжить или Escape для выхода");

            var keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
                return;
            else if (keyInfo.Key == ConsoleKey.Enter)
                AddExpenses();
        }

        public static void RemoveBudget() // Метод удаления запланированного Бюджета
        {
            Console.WriteLine("Удаление");
            ConsoleKeyInfo keyInfo;
            int number = 0;

            do
            {
                Console.Clear();

                for (int NumberCinema = 0; NumberCinema < titlesRemove.Count; NumberCinema++)
                {
                    if (NumberCinema == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(titlesRemove[NumberCinema]);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + titlesRemove.Count()) % titles.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % titlesRemove.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (number == 0)
                        RemoveIncome();
                    else if (number == 1)
                        RemoveExpenses();

                }

            }
            while (keyInfo.Key != ConsoleKey.Escape);

        }

        public static void RemoveIncome()
        {
            Console.Clear();
            if (expenses.Count == 0)
            {
                Console.WriteLine("Нету данных для удаления");
                Console.ReadKey();
                return;
            }

            int count = 0;
            foreach (var incomeItem in income)
            {
                Console.WriteLine($"{count++} - Сумма: {incomeItem.Amount}, описание: {incomeItem.Description}");
            }
            Console.WriteLine("Выберите число для удаления: ");
            int input = int.Parse(Console.ReadLine());
            income.RemoveAt(input);

            Console.WriteLine("Данные успешно удалены");
            Console.WriteLine($"Нажмите Enter чтобы продолжить или Escape для выхода");

            var keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
                return;
            else if (keyInfo.Key == ConsoleKey.Enter)
                RemoveIncome();
        }
        public static void RemoveExpenses()
        {
            Console.Clear();
            if (expenses.Count == 0)
            {
                Console.WriteLine("Нету данных для удаления");
                Console.ReadKey();
                return;
            }

            int count = 0;
            foreach (var expensesItem in expenses)
            {
                Console.WriteLine($"{count++} - Сумма: {expensesItem.Amount}, описание: {expensesItem.Description}");
            }
            Console.WriteLine("Выберите число для удаления: ");
            int input = int.Parse(Console.ReadLine());
            expenses.RemoveAt(input);

            Console.WriteLine("Данные успешно удалены");
            Console.WriteLine($"Нажмите Enter чтобы продолжить или Escape для выхода");

            var keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
                return;
            else if (keyInfo.Key == ConsoleKey.Enter)
                RemoveExpenses();
        }

    }
}
