using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
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


        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }


        public AccountTypes GetAccountType()
        {
            return accountType;
        }


        public string GetInfo()
        {
            return $"Счёт номер\t{accountNumber}\nБаланс\t\t{balance}\nТип\t\t{accountType}\n";
        }

        private void SetAccountNumber()
        {
            this.accountNumber = ++counter;
        }
    }
}
