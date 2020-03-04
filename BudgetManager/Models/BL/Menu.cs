using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BudgetManager.Models.BL.MenuContent;
using BudgetManager.Models.DB;

namespace BudgetManager.Models.BL
{
    class Menu
    {
        public void RunMenu()
        {
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
                    MenuList.ShowList();
                    break;
                case "2":
                    MenuReport.ShowReport();
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
            }
        }
    }
}
