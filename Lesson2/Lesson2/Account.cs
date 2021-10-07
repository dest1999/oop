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
        private int number;
        private decimal balance;
        private AccountTypes accountType;

        public Account()
        {
            number = ++counter;
        }

        public int GetNumber()
        {
            return number;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public AccountTypes GetAccountType()
        {
            return accountType;
        }


        public void SetBalance(decimal Balance)
        {
            this.balance = Balance;
        }

        public void SetAccountType(AccountTypes AccountType)
        {
            this.accountType = AccountType ;
        }
    }
}
