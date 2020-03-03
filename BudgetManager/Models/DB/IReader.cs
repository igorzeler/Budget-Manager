using BudgetManager.Models.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.DB
{
    internal interface IReader
    {
        IEnumerable<Transaction> ReadAll();
        int GetNextId();
    }
}
