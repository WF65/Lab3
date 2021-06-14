using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise3
{
    class SortExpense
    {
        public List<Expenses> SortExpenses(List<Expenses> account)
        {
            var results = from e in account
                          orderby e.Date ascending
                          orderby e.Description ascending
                          select e;

            List<Expenses> res = new List<Expenses>();
            foreach (var e in results)
            {
                res.Add(e);
            }

            return res;
        }
    }
}
