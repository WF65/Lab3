﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Expenses
    {
        public int No { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public void CreateExpense(int no)
        {
            setDate();
            setDescription();
            setCategory();
            setAmount();
            No = no;
        }

        void setCategory()
        {
            Console.WriteLine("Please enter category:");
            Category = Console.ReadLine();
        }

        void setAmount()
        {
            Console.WriteLine("Please enter amount:");
            Amount = Convert.ToDecimal(Console.ReadLine());
        }

        void setDescription()
        {
            Console.WriteLine("Please enter description:");
            bool check = true;
            while (check)
            {
                string description = Console.ReadLine();
                if (description == "" || description == null)
                {
                    Console.WriteLine("Description cannot be empty, please re-enter:");
                }
                else
                {
                    Description = description.Trim();
                    check = false;
                }
            }
        }

        void setDate()
        {
            Console.WriteLine("Please enter data in the form of MM/DD/YYYY");
            Console.WriteLine("Enter month:");
            int month = 1;
            bool m = true;
            while (m)
            {
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Month out of range, please re-enter month");
                }
                else
                {
                    m = true;
                }
            }
            string monthString;
            if (month < 10)
            {
                monthString = "0" + Convert.ToString(month);
            }
            else
            {
                monthString = Convert.ToString(month);
            }
            Console.WriteLine("Enter day:");
            int day = 1;
            bool d = true;
            while (d)
            {
                day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 31)
                {
                    Console.WriteLine("Day out of range, please re-enter day");
                }
                else
                {
                    d = true;
                }
            }
            string dayString;
            if (day < 10)
            {
                dayString = "0" + Convert.ToString(day);
            }
            else
            {
                dayString = Convert.ToString(day);
            }

            Console.WriteLine("enter year:");
            int year = 2000;
            bool y = true;
            while (y)
            {
                year = Convert.ToInt32(Console.ReadLine());
                if (year < 1000 || year > 31)
                {
                    Console.WriteLine("Year out of range, please re-enter year");
                }
                else
                {
                    y = true;
                }
            }

            Date = Convert.ToString(year) + monthString + dayString;
        }
    }
}
