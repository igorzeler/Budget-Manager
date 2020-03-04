using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Models.BL
{
    interface IMenu
    {
        void RunMenu();
        void DisplayMenu();
        void RunSelected(string selected);
    }
}
