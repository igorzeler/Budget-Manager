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

        public List(Transaction transaction)
        {
            _transaction = transaction;
        }

        public void DisplayLane()
        {
            Console.WriteLine($"{_transaction.Id} {_transaction.Name} {_transaction.Amount}zł {_transaction.Date.ToShortDateString()}");
        }
    }
}
