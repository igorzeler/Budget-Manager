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
            IList<Transaction> transactions = new List<Transaction>();

            if (!File.Exists(_fileName))
            {
                return transactions;
            }

            IEnumerable<string> lines = File.ReadAllLines(_fileName);

            foreach (var line in lines)
            {
                Transaction transaction = TextToTransaction(line);

                transactions.Add(transaction);
            }

            return transactions;
        }

        private Transaction TextToTransaction(string line)
        {
            const string pattern = "dd-MM-yyyy";
            string[] columns = line.Split(';');

            var id = int.Parse(columns[0]);
            var name = columns[1];
            var type = columns[2];
            var amount = decimal.Parse(columns[3]);
            DateTime date = DateTime.ParseExact(columns[4], pattern, null);

            if (type == "I")
            {
                return new Income(id, amount, name, date);
            }
            else
            {
                return new Outcome(id, amount, name, date);
            }
        }
    }
}
