using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.BL;
using BudgetManager.Models.DB;

namespace BudgetManager.Models.Stats
{
    class List
    {
        private IReader _reader;

        public List(IReader reader)
        {
            _reader = reader;
        }

        private void DisplayLane(Transaction transaction)
        {
            Console.WriteLine($"{transaction.Id} {transaction.Name} {transaction.Amount}zł {transaction.Date.ToShortDateString()}");
        }
    }
}
