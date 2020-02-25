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

        private void DisplayLine(Transaction transaction)
        {
            string type;

            switch (transaction.Type)
            {
                case Transaction.TransactionType.Income:
                    type = "INCOME";
                    break;
                case Transaction.TransactionType.Outcome:
                    type = "OUTCOME";
                    break;
            }

            Console.WriteLine($"{transaction.Id} {transaction.Name} {transaction.Amount}zł {transaction.Date.ToShortDateString()}");
        }

        public void DisplayList()
        {
            IEnumerable<Transaction> list = _reader.ReadAll();

            foreach (Transaction  transaction in list)
            {
                DisplayLine(transaction);
            }
        }
    }
}
