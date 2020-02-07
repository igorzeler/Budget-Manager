using BudgetManager.Models.DB;
using Models.BudgetManager.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.BudgetManager.DB
{
    class File : IDatabase
    {
        Transaction IDatabase.Read()
        {
            throw new NotImplementedException();
        }

        void IDatabase.Write(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
