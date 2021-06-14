using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise3
{
    class SearchCost
    {
        public void searchCost(List<Expenses> account)
        {
            Console.WriteLine("Please enter keyword");
            string keyWord = Console.ReadLine();

            var results = from e in account
                          where e.Category.Contains(keyWord) || e.Description.Contains(keyWord)
                          select e;
            foreach (var e in results)
            {
                Console.WriteLine("{0}\t{1}\t{2}", e.No, e.Date, e.Description);
            }
        }
        
    }
}
