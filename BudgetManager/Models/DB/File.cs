using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.BL;

namespace BudgetManager.Models.DB
{
    class File : IReader, IWriter
    {
        public Transaction Read()
        {
            return new Income(1, 1500.0M, "Salary", new DateTime(2019, 5, 21));
        }

        public void Write(Transaction transaction)
        {
        }
    }
}
