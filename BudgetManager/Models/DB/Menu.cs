using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.DB
{
    class Menu
    {
        private static IWriter _writer;
        private static IReader _reader;

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
    }
}
