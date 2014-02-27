namespace BankMain
{
    using System;
    public class DepositAccount : Account, IAccount
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { 
        }

        // public override decimal DepositMoney(decimal amountOfMoney)
        // {
        //     return base.DepositMoney(amountOfMoney);
        // }

        public override decimal WithDrawMoney(decimal amountOfMoney)
        {
            this.Balance = this.Balance - amountOfMoney;
            return this.Balance;
        }

        public override decimal CalculateInterest(int numberMonths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberMonths);
            }
        }
    }
}
