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

            for (int i = 0; i < 10; i++)
            {
                Expenses e = new Expenses();
                e.CreateExpense(noOfExpenses);
                account.Add(e);
                noOfExpenses++;
            }

            Console.WriteLine(account);
            Console.WriteLine("-------------------------");

            SearchCost searchCost = new SearchCost();
            searchCost.searchCost(account);
            Console.WriteLine("-------------------------");

            ShowExpense showExpense = new ShowExpense();
            showExpense.ShowExpenses(account);
            Console.WriteLine("-------------------------");

            SortExpense sortExpense = new SortExpense();
            sortExpense.SortExpenses(account);
            Console.WriteLine(account);
            Console.WriteLine("-------------------------");

            DeleteData deleteData = new DeleteData();
            account = deleteData.DeleteCard(account, noOfExpenses);
            Console.WriteLine(account);





        }

        
    }
}
