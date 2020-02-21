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
        

        public List(IReader reader)
        {
            _reader = reader;
        }

        private void DisplayLane(Transaction transaction)
        {
            Console.WriteLine($"{transaction.Id} {transaction.Name} {transaction.Amount}zł {transaction.Date.ToShortDateString()}");
        }

        public void DisplayList()
        {
            IEnumerable<Transaction> list = _reader.ReadAll();

            foreach (Transaction  transaction in list)
            {
                DisplayLane(transaction);
            }
        }
    }
}
