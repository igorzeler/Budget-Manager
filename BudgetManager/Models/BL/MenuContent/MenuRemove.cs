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
        private static IWriter _writer;
        private static IReader _reader;
        public static void RemoveTransaction()
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
