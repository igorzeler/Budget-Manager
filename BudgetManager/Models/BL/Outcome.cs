using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.BL
{
    class Outcome: Transaction
    {
        public Outcome(int id, decimal amount, string name, DateTime date)
        {
            Id = id;
            Amount = amount;
            Name = name;
            Date = date;
        }

    }
}
