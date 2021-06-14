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
            int deleteNo = 0;
            bool check = true;
            while (check)
            {
                deleteNo = Convert.ToInt32(Console.ReadLine());
                if (deleteNo < 1 || deleteNo >= no)
                {
                    Console.WriteLine("Incorrect card number, please re-enter:");
                }
                else
                {
                    check = false;
                }
            }
                

            var results = from e in account
                          where e.No != deleteNo
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
