﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using Models.BudgetManager.BL;
using Models.BudgetManager.DB;
using Models.BudgetManager.Stats;

namespace BudgetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = new File();
            Income income1 = ;

            List list = new List(income1);
            Outcome outcome1 = new Outcome();

            list.DisplayLane();
            
            Console.WriteLine($"{outcome1.Id} {outcome1.Name} {outcome1.Amount}zł {outcome1.Date.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
