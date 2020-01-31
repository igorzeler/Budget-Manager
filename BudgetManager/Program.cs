using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Income income1 = new Income();
            income1.Id = 1;
            income1.Name = "Salary";
            income1.Amount = 1500.0M;
            income1.Date = new DateTime(2019, 5, 21);
            
            Console.WriteLine($"{income1.Id} {income1.Name} {income1.Amount} {income1.Date}");
            Console.ReadKey();
        }
    }
}
