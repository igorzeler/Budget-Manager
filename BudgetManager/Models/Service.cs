using BudgetManager.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models
{
    class Service
    {
        private IReader _reader;
        private IWriter _writer;
        public Service(IReader reader, IWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void AddIncome(decimal amount, string name, DateTime date)
        {

        }

        public void AddOutcome(decimal amount, string name, DateTime date)
        {

        }

        public void RemovebyId(int id)
        {

        }
    }
}
