using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.Services;

namespace BudgetManager.Models.BL.MenuContent
{
    class MenuIncome
    {
        public static void AddIncome()
        {
            Console.Clear();
            var reader = DbAccess.SetDbReader();
            var writer = DbAccess.SetDbWriter();

            Console.WriteLine("New income");

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Amount: ");
            var value = Console.ReadLine();
            var amount = decimal.Parse(value);

            Console.WriteLine("Date: ");
            value = Console.ReadLine();
            DateTime date = DateTime.Parse(value);

            Service service = new Service(reader, writer);
            service.AddIncome(amount, name, date);
        }
    }
}
