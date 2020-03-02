using BudgetManager.Models.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.DB
{
    class Reader : IReader
    {
        private string _fileName;

        public Reader(string fileName)
        {
            _fileName = fileName;
        }

        public int GetNextId()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> ReadAll()
        {
            IEnumerable<string> lines = File.ReadAllLines(_fileName);
        }
    }
}
