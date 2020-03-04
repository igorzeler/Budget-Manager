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
        private static IWriter _writer;
        private static IReader _reader;

        static void Main(string[] args)
        {
            var menu = new Menu();

            _reader = new Reader("db.txt");
            _writer = new Writer("db.txt");
            
            menu.RunMenu();
        }
    }
}
