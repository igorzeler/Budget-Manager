using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.DB
{
    internal static class DbAccess
    {
        public static IWriter SetDbWriter()
        {
            IWriter writer = new Writer("db.txt");
            return writer;
        }
        public static IReader SetDbReader()
        {
            IReader reader = new Reader("db.txt");
            return reader;
        }
    }
}
