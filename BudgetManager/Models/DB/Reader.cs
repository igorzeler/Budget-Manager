using BudgetManager.Models.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BudgetManager.Models.DB
{
    class Reader : IReader
    {
        private readonly string _fileName;

        public Reader(string fileName)
        {
            _fileName = fileName;
        }

        public int GetNextId()
        {
            IEnumerable<Transaction> items = ReadAll();

            var transactions = items.ToList();
            if (!transactions.Any())
            {
                return 1;
            }
            var lastIndex = transactions.Count() - 1;
            return transactions.ElementAt(lastIndex).Id + 1;
        }

        public IEnumerable<Transaction> ReadAll()
        {
            IList<Transaction> transactions = new List<Transaction>();
            IEnumerable<string> lines = File.ReadAllLines(_fileName);

            if (!File.Exists(_fileName))
            {
                return transactions;
            }
            
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
            
            return new Outcome(id, amount, name, date);
            
        }
    }
}
