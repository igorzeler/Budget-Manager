using BudgetManager.Models.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.DB
{
    class Reader : IReader
    {
        public int GetNextId()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}
