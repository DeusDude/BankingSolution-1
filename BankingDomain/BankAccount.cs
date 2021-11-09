namespace BankingDomain
{
    public enum BankAccountType { Standard, Gold }
    public class BankAccount
    {
        private decimal _balance = 5000M;

        public BankAccountType AccountType = BankAccountType.Standard;
        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            _balance -= amountToWithdraw;
        }

        public void Deposit(decimal amountToDeposit)
        {
            if (AccountType == BankAccountType.Gold)
            {
                _balance += amountToDeposit * 1.10M;
            }
            else
            {
                _balance += amountToDeposit;
            }
        }
    }
}
