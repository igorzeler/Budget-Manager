using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.Services;

namespace BudgetManager.Models.BL.MenuContent
{
    class MenuOutcome
    {
        private static IWriter _writer;
        private static IReader _reader;

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
    }
}
