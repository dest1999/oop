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

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public void SetAccountNumber()
        {
            this.accountNumber = ++counter;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }

        public void SetBalance(decimal balance)
        {
            this.balance = balance;
        }

        public AccountTypes GetAccountType()
        {
            return accountType;
        }

        public void SetAccountType(AccountTypes accountType)
        {
            this.accountType = accountType;
        }

        public string GetInfo()
        {
            return $"Счёт номер\t{accountNumber}\nБаланс\t\t{balance}\nТип\t\t{accountType}";
        }

    }
}
