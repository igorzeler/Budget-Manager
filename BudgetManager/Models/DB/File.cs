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
        private List<Transaction> _list;
        
        public void Write(Transaction transaction)
        {
        }

        public void Remove(int id)
        {

        }

        public IEnumerable<Transaction> ReadAll()
        {

        }

        public int GetNextId()
        {

        }
    }
}
