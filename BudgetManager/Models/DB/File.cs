using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.DB;
using BudgetManager.Models.BL;

namespace BudgetManager.Models.DB.Files
{
    class File : IReader, IWriter
    {
        public File()
        {
            _list = new List<Transaction>();
        }

        private IList<Transaction> _list;
        
        public void Write(Transaction transaction)
        {
            _list.Add(transaction);
        }

        public void Remove(int id)
        {
            Transaction toRemove = null;
            foreach (Transaction transaction in _list)
            {
                if (transaction.Id == id)
                {
                    toRemove = transaction;
                    break;
                }
            }
            _list.Remove(toRemove);
        }

        public IEnumerable<Transaction> ReadAll()
        {
            return _list;
        }

        public int GetNextId()
        {
            int lastIndex = _list.Count - 1;
            if ( _list.Count == 0 )
            {
                return 1;
            }
            return _list[lastIndex].Id+1;
        }
    }
}
