using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.BL
{
    abstract class Transaction
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public decimal Amount { get; protected set; }
        public DateTime Date { get; protected set; }

        public enum TransactionType { Income, Outcome };

    }
}
