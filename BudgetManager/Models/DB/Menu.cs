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
    }
}
