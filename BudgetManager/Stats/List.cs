using BudgetManager.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Stats
{
    class List
    {
        private Transaction _transaction;

        public List(Transaction transaction)
        {
            _transaction = transaction;
        }
    }
}
