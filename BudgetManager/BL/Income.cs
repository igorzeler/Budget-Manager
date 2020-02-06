using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.BL
{
    class Income: Transaction
    {
        public Income(int id, decimal amount, string name, DateTime date)
        {
            Id = id;
            Amount = amount;
            Name = name;
            Date = date;
        }
    }
}
