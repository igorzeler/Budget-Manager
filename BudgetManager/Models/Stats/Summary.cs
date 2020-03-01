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
        private readonly IReader _reader;

        public Summary(IReader reader)
        {
            _reader = reader;
        }

        public void DisplayReport(int year, int month)
        {
            IEnumerable<Transaction> list = GetTransactions(year, month);

            decimal incomes = SumIncomes(list);
            decimal outcomes = SumOutcomes(list);
            decimal balance = Balance(incomes, outcomes);

            Console.WriteLine($"Monthly summary {month}/{year}");
            Console.WriteLine($"Sum of incomes: {incomes}£");
            Console.WriteLine($"Sum of outcomes: {outcomes}£");
            Console.WriteLine($"Monthly balance : {balance}£");
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

        private IEnumerable<Transaction> GetTransactions(int year, int month)
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
