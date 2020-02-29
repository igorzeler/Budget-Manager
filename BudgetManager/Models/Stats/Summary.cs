using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.BL;
using BudgetManager.Models.DB;

namespace BudgetManager.Models.Stats
{
    class Summary
    {
        private IReader _reader;

        public Summary(IReader reader)
        {
            _reader = reader;
        }

        public void DisplayReport(int year, int month)
        {
            IEnumerable<Transaction> list = GetTransaction(year, month);
        }

        private decimal SumIncomes(IEnumerable<Transaction> list)
        {
            decimal sum = 0.0M;

            foreach (Transaction transaction in list)
            {
                if (transaction.Type == Transaction.TransactionType.Income)
                {
                    sum += transaction.Amount;
                }
            }
            return sum;
        }
        private decimal SumOutcomes(IEnumerable<Transaction> list)
        {
            decimal sum = 0.0M;

            foreach (Transaction transaction in list)
            {
                if (transaction.Type == Transaction.TransactionType.Outcome)
                {
                    sum += transaction.Amount;
                }
            }
            return sum;
        }

        private IEnumerable<Transaction> GetTransaction(int year, int month)
        {
            IEnumerable<Transaction> list = _reader.ReadAll();

            List<Transaction> reportList = new List<Transaction>();

            foreach (var transaction in list)
            {
                if (transaction.Date.Year == year && transaction.Date.Month == month)
                {
                    reportList.Add(transaction);
                }
            }
            return reportList;
        }

        private decimal Balance(decimal incomes, decimal outcomes) => incomes - outcomes;
    }
}
