using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise3
{
    class ShowExpense
    {
        public void ShowExpenses(List<Expenses> account)
        {
            Console.WriteLine("Please enter starting date in YYYYMMDD format");
            int startingDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter ending date in YYYYMMDD format");
            int endingDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter category");
            string category = Console.ReadLine();

            var results = from e in account
                          where e.Category == category && Convert.ToInt32(e.Date) > startingDate && Convert.ToInt32(e.Date) < endingDate
                          select e;

            foreach (var e in results)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", e.No, e.Date, e.Description, e.Category, e.Amount);
            }
            Console.WriteLine("The total number of data is " + results.Count());
        }
    }
}
