using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise3
{
    class DeleteData
    {
        public List<Expenses> DeleteCard(List<Expenses> account, int no)
        {
            Console.WriteLine("Please the number of the card to be deleted");
            int deleteNo = Convert.ToInt32(Console.ReadLine());

            var results = from e in account
                          where e.No == deleteNo
                          select e;

            foreach (var e in results)
            {
                account.Remove(e);
            }

            return account;

        }
        
    }
}
