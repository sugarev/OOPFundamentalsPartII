namespace BankMain
{
    using System;
    public abstract class Account : IAccount
    {
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        public decimal Balance
        {
            get 
            {
                return this.balance;
            }
            protected set 
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get 
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public Customer Customer { get; private set; }

        public virtual decimal DepositMoney(decimal amountOfMoney)
        {
            this.balance = this.balance + amountOfMoney;
            return this.balance;
        }

        public virtual decimal WithDrawMoney(decimal amountOfMoney)
        {
            this.balance = this.balance - amountOfMoney;
            return this.balance;
        }

        public virtual decimal CalculateInterest(int numberMonths)
        {
            decimal interestAmount = numberMonths * this.interestRate;
            return interestAmount;
        }
    }
}
