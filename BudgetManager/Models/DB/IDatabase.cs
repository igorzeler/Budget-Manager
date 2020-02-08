using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.BL;

namespace BudgetManager.Models.DB
{
    interface IDatabase
    {
        void Write(Transaction transaction);
        Transaction Read();
    }
}
