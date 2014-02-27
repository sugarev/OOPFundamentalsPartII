namespace BankMain
{
    using System;
    public class MortgageAccount : Account, IAccount
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal DepositMoney(decimal amountOfMoney)
        {
            return base.DepositMoney(amountOfMoney);
        }

        public override decimal CalculateInterest(int numberMonths)
        {
            if (base.Customer == Customer.Company)
            {
                if (numberMonths <= 12)
                {
                    return (base.InterestRate / 2) * numberMonths;
                }
                else
                {
                    return base.CalculateInterest(numberMonths - 12);
                }
            }

            if (base.Customer == Customer.Individual)
            {
                if (numberMonths <= 6)
                {
                    base.InterestRate = 0;
                    return numberMonths * base.InterestRate;
                }
                else
                {
                    return base.CalculateInterest(numberMonths - 6);
                }
            }
            return 0;
        }
    }
}
