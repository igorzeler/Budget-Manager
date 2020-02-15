using BudgetManager.Models.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.DB
{
    interface IWriter
    {
        void Write(Transaction transaction);
        void Remove(int id);
    }
}
