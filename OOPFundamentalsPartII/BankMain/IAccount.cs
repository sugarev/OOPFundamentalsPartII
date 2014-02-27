namespace BankMain
{
    using System;
    public interface IAccount
    {
        Customer Customer { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }

        decimal DepositMoney(decimal amountOfMoney);
        decimal WithDrawMoney(decimal amountOfMoney);
        decimal CalculateInterest(int numberMonths);
    }
}
