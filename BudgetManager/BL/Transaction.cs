using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.BL
{
    abstract class Transaction
    {
        public int Id;
        public string Name;
        public decimal Amount;
        public DateTime Date;
    }
}
