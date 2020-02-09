using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.BL;
using BudgetManager.Models.Stats;

namespace BudgetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            File database = new File();
            
            Transaction income1 = database.Read();
            List list = new List(income1);
            
            Transaction outcome1 = database.Read();
            List list2 = new List(outcome1);

            list.DisplayLane();
            list2.DisplayLane();

            Console.ReadKey();
        }
    }
}
