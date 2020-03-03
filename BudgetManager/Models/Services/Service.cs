using BudgetManager.Models.BL;
using BudgetManager.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.Services
{
    internal class Service
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;
        public Service(IReader reader, IWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void AddIncome(decimal amount, string name, DateTime date)
        {
            var id = _reader.GetNextId();

            var income = new Income(id, amount, name, date);

            _writer.Write(income);
        }

        public void AddOutcome(decimal amount, string name, DateTime date)
        {
            var id = _reader.GetNextId();

            var outcome = new Outcome(id, amount, name, date);

            _writer.Write(outcome);
        }

        public void RemoveById(int id)
        {
            _writer.Remove(id);
        }
    }
}
