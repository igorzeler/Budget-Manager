using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.Services;

namespace BudgetManager.Models.BL.MenuContent
{
    class MenuRemove
    {
        public static void RemoveTransaction()
        {
            Console.Clear();

            var reader = DbAccess.SetDbReader();
            var writer = DbAccess.SetDbWriter();

            Console.WriteLine("Input ID to remove: ");
            var selectedId = Console.ReadLine();
            var id = int.Parse(selectedId);

            Service service = new Service(reader, writer);
            service.RemoveById(id);
        }
    }
}
