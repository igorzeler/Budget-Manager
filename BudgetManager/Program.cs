using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.BL;

namespace BudgetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Income income1 = new Income(1,  1500.0M, "Salary", new DateTime(2019, 5, 21));


            Outcome outcome1 = new Outcome();


            Console.WriteLine($"{income1.Id} {income1.Name} {income1.Amount}zł {income1.Date.ToShortDateString()}");
            Console.WriteLine($"{outcome1.Id} {outcome1.Name} {outcome1.Amount}zł {outcome1.Date.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
