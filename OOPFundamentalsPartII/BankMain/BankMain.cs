namespace BankMain
{
    using System;
    public class BankMain
    {
        static void Main()
        {
            DepositAccount dep = new DepositAccount(Customer.Company, 500, 5);
            decimal balance = dep.DepositMoney(500);
            decimal rate = dep.CalculateInterest(5);
            Console.WriteLine(rate);

            LoanAccount loan = new LoanAccount(Customer.Company, 400, 4);
            decimal rateLoan = loan.CalculateInterest(5);
            Console.WriteLine(rateLoan);

            MortgageAccount mortgage = new MortgageAccount(Customer.Company, 500, 5);
            decimal mortgageInter = mortgage.CalculateInterest(12);
            Console.WriteLine(mortgageInter);
        }
    }
}
