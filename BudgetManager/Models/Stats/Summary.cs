using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManager.Models.BL;
using BudgetManager.Models.DB;

namespace BudgetManager.Models.Stats
{
    class Summary
    {
        private IReader _reader;

        public Summary(IReader reader)
        {
            _reader = reader;
        }

        public void DisplayReport(int year, int month)
        {
            IEnumerable<Transaction> list = _reader.ReadAll();

            List<Transaction> repoList = new List<Transaction>();
        }
    }
}
