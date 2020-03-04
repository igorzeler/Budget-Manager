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
        public static void ShowList()
        {
            Console.Clear();
            var reader = DbAccess.SetDbReader();

            Console.WriteLine("Display transactions");
            var list = new List(reader);

            list.DisplayList();
            Console.ReadKey();
        }
    }
}
