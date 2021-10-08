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

        public Account(decimal Balance) : this(Balance, AccountTypes.Дебетовый)
        {
            balance = Balance;
        }

        public Account(AccountTypes AccountType) : this(0, AccountType)
        {
            accountType = AccountType;
        }

        public Account(decimal Balance, AccountTypes AccountType)
        {
            balance = Balance;
            accountType = AccountType;
            SetAccountNumber();
        }
        public int GetNumber()
        {
            return number;
        }

        public bool PutToAccount(decimal amount)
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
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                return true;
            }

            return false;
        }


        public decimal Balance 
        {  
            get 
            {  
                return balance; 
            } 
            //set 
            //{ 
            //    balance = value; 
            //} 
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

        public string GetInfo()
        {
            return $"Счёт номер\t{number}\nБаланс\t\t{balance}\nТип\t\t{accountType}";
        }

        private void SetAccountNumber()
        {
            number = ++counter;
        }
    }
}
