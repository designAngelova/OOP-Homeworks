using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BankOfCurtovoKoinareApp
{
    public class TestBankApp
    {
        static void Main(string[] args)
        {
            ICollection<IAccount> accounts = new Collection<IAccount>();

            Account daccount = new DepositAccount(Customer.Individual, 600.00m, 10.0m);
            Account laccount = new LoanAccount(Customer.Company, 500.00m, 6);
            Account maccount = new MortgageAccount(Customer.Individual, 4440.00m, 7);

            Console.WriteLine("{0:C}", daccount.CalculateInterest(12));
            Console.WriteLine("{0:C}", laccount.CalculateInterest(12));
            Console.WriteLine("{0:C}", maccount.CalculateInterest(7));
        }
    }
}
