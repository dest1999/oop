using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Account
    {
        private static int counter;

        private int accountNumber;
        private decimal balance;
        private AccountTypes accountType;

        public Account() : this(0, AccountTypes.Regular)
        {

        }

        public Account(decimal balance) : this(balance, AccountTypes.Regular)
        {

        }

        public Account(AccountTypes accountType) : this(0, accountType)
        {

        }

        public Account(decimal balance, AccountTypes accountType)
        {
            this.balance = balance;
            this.accountType = accountType;
            SetAccountNumber();
        }
        
        public static bool operator == (Account account1, Account account2)
        {

            if (account1.accountNumber == account2.accountNumber && account1.accountType == account2.accountType && account1.balance == account2.balance)
            {
                return true;
            }
            return false;
        }

        public static bool operator != (Account account1, Account account2)
        {
            return !(account1 == account2);
        }

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }

        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public AccountTypes AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            }
        }

        public bool Transfer(Account sourceAccount, decimal amount)
        {
            if (sourceAccount.WithdrawFromAccount(amount))
            {
                return this.DepositToAccount(amount);
            }
            return false;
        }

        public bool DepositToAccount(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }
            return false;
        }

        public bool WithdrawFromAccount(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Счёт номер\t{accountNumber}\nБаланс\t\t{balance}\nТип\t\t{accountType}\n";
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(accountNumber);
            hash.Add(balance);
            hash.Add(accountType);
            return hash.ToHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Account)
            {
                return false;
            }
            return this == (Account)obj;
        }

        private void SetAccountNumber()
        {
            this.accountNumber = ++counter;
        }
    }
}