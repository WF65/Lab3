using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class HouseHoldAccounts
    {

        static void Main(string[] args)
        {
            List<Expenses> account = new List<Expenses>();
            int noOfExpenses = 1;

            for (int i = 0; i < 4; i++)
            {
                Expenses e = new Expenses();
                e.CreateExpense(noOfExpenses);
                account.Add(e);
                noOfExpenses++;
            }

            foreach (var e in account)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", e.No, e.Date, e.Description, e.Category, e.Amount);
            }
            Console.WriteLine("-------------------------");

            SearchCost searchCost = new SearchCost();
            searchCost.searchCost(account);
            Console.WriteLine("-------------------------");

            ShowExpense showExpense = new ShowExpense();
            showExpense.ShowExpenses(account);
            Console.WriteLine("-------------------------");

            SortExpense sortExpense = new SortExpense();
            sortExpense.SortExpenses(account);
            foreach (var e in account)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", e.No, e.Date, e.Description, e.Category, e.Amount);
            }
            Console.WriteLine("-------------------------");

            DeleteData deleteData = new DeleteData();
            account = deleteData.DeleteCard(account, noOfExpenses);
            foreach (var e in account)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", e.No, e.Date, e.Description, e.Category, e.Amount);
            }





        }

        
    }
}
