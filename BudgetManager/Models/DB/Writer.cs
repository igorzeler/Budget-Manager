using BudgetManager.Models.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.DB
{
    class Writer : IWriter
    {
        private string _fileName;

        public Writer(string fileName)
        {
            _fileName = fileName;
        }
        public void Remove(int id)
        {
            IEnumerable<string> lines = File.ReadAllLines(_fileName);
            IList<string> toSave = new List<string>();

            foreach (var line in lines)
            {
            }
        }

        public void Write(Transaction transaction)
        {
            string line = TransactionToText(transaction);
            File.AppendAllText(_fileName, line);
        }

        private string TransactionToText(Transaction transaction)
        {
            string newLine = Environment.NewLine;
            string type = "I";

            if (transaction.Type == Transaction.TransactionType.Outcome )
            {
                type = "O"; //letter 'O'
            }

            const string pattern = "dd-MM-yyyy";
            var line = string.Format($"{transaction.Id};" +
                                        $"{transaction.Name};" +
                                        $"{type};" +
                                        $"{transaction.Amount};" +
                                        $"{transaction.Date.ToString(pattern)}");
            return line + newLine;
        }
    }
}
