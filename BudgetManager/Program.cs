using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.BL;
using BudgetManager.Models.Stats;

namespace BudgetManager
{
    class Program
    {
        private static File _file;
        static void Main(string[] args)
        {
            _file = new File();
            var selected = "";
            do
            {
                DisplayMenu();
                selected = Console.ReadLine();
                RunSelected(selected);
            }
            while (selected != "6");
        }
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Transaction list");
            Console.WriteLine("2 - Monthly summary");
            Console.WriteLine("3 - Add outcome");
            Console.WriteLine("4 - Add income");
            Console.WriteLine("5 - Remove transaction");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("Chosen action: ");
        }
        private static void RunSelected(string selected)
        {
            switch (selected)
            {
                case "1":
                    ShowList();
                    break;
                case "2":
                    ShowReport();
                    break;
                case "3":
                    AddOutcome();
                    break;
                case "4":
                    AddIncome();
                    break;
                case "5":
                    RemoveTransaction();
                    break;
                default:
                    break;

            }
        }

        private static void ShowList()
        {
            Console.Clear();
        }
        private static void ShowReport()
        {
            Console.Clear();
        }
        private static void AddOutcome()
        {
            Console.Clear();
        }
        private static void AddIncome()
        {
            Console.Clear();
        }
        private static void RemoveTransaction()
        {
            Console.Clear();
        }
    }
}
