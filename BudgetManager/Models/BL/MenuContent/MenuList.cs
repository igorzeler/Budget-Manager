using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.Stats;

namespace BudgetManager.Models.BL.MenuContent
{
    class MenuList
    {
        private static IReader _reader;
        public static void ShowList()
        {
            Console.Clear();
            Console.WriteLine("Display transactions");

            var list = new List(_reader);

            list.DisplayList();
            Console.ReadKey();
        }
    }
}
