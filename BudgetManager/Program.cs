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
            _reader = new Reader("db.txt");
            _writer = new Writer("db.txt");
            var menu = new Menu();

            menu.RunMenu();
            
        }
        
        private static void ShowList()
        {
            Console.Clear();
            Console.WriteLine("Display transactions");

            List list = new List(_reader);

            list.DisplayList();
            Console.ReadKey();
        }
        private static void ShowReport()
        {
            Console.Clear();

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            Summary report = new Summary(_reader);

            report.DisplayReport(year, month);
            Console.ReadKey();
        }
        private static void AddOutcome()
        {
            Console.Clear();

            Console.WriteLine("New outcome");

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Amount: ");
            var value = Console.ReadLine();
            var amount = decimal.Parse(value);

            Console.WriteLine("Date: ");
            value = Console.ReadLine();
            DateTime date = DateTime.Parse(value);

            Service service = new Service(_reader, _writer);
            service.AddOutcome(amount, name, date);
        }
        private static void AddIncome()
        {
            Console.Clear();

            Console.WriteLine("New income");

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Amount: ");
            var value = Console.ReadLine();
            var amount = decimal.Parse(value);

            Console.WriteLine("Date: ");
            value = Console.ReadLine();
            DateTime date = DateTime.Parse(value);

            Service service = new Service(_reader, _writer);
            service.AddIncome(amount, name, date);
        }
        private static void RemoveTransaction()
        {
            Console.Clear();
            Console.WriteLine("Input ID to remove: ");
            var selectedId = Console.ReadLine();
            var id = int.Parse(selectedId);

            Service service = new Service(_reader, _writer);
            service.RemoveById(id);
        }
    }
}
