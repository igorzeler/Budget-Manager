using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.Stats;

namespace BudgetManager.Models.BL.MenuContent
{
    
    class MenuReport
    {
        private static IReader _reader;
        public static void ShowReport()
        {
            Console.Clear();

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            Summary report = new Summary(_reader);

            report.DisplayReport(year, month);
            Console.ReadKey();
        }
    }
}
