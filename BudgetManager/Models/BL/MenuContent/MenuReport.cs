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
        public static void ShowReport()
        {
            Console.Clear();

            var reader = DbAccess.SetDbReader();

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            Summary report = new Summary(reader);

            report.DisplayReport(year, month);
            Console.ReadKey();
        }
    }
}
