using BudgetManager.Models.DB;
using BudgetManager.Models.Services;
using BudgetManager.Models.Stats;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using BudgetManager.Models.BL;

namespace BudgetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            menu.RunMenu();
        }
    }
}
