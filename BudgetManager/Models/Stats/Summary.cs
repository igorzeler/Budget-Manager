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
            return list.Where(t => t.Type == Transaction.TransactionType.Income).Sum(t => t.Amount);
        }
        private decimal SumOutcomes(IEnumerable<Transaction> list)
        {
            return list.Where(t => t.Type == Transaction.TransactionType.Outcome).Sum(t => t.Amount);
        }

        private IEnumerable<Transaction> GetTransactions(int year, int month)
        {
            IEnumerable<Transaction> list = _reader.ReadAll();

            return list.Where(t => t.Date.Year == year && t.Date.Month == month).ToList();
        }

        private decimal Balance(decimal incomes, decimal outcomes) => incomes - outcomes;
    }
}
