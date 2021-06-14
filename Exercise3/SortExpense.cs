using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise3
{
    class SortExpense
    {
        public void SortExpenses(List<Expenses> account)
        {
            var results = from e in account
                          orderby e.Date, e.Description
                          select e;

            //List<Expenses> res = new List<Expenses>();
            //foreach (var e in results)
            //{
            //    res.Add(e);
            //}

            //return res;

            foreach (var e in results)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", e.No, e.Date, e.Description, e.Category, e.Amount);
            }
        }
    }
}
