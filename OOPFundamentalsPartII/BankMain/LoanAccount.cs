namespace BankMain
{
    using System;
    public class LoanAccount : Account, IAccount
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { 
        }

        public override decimal DepositMoney(decimal amountOfMoney)
        {
            return base.DepositMoney(amountOfMoney);
        }

        public override decimal CalculateInterest(int numberMonths)
        {

            if (this.Customer == Customer.Company)
            {
                if (numberMonths > 2)
                {
                    return base.CalculateInterest(numberMonths - 2);
                }
                return 0;
                
            }

            if (this.Customer == Customer.Individual)
            {
                if (numberMonths > 3)
                {
                    return base.CalculateInterest(numberMonths - 3);
                }
                return 0;
            }
            return 0;
        }

        
    }
}
