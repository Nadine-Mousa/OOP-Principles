using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal amount)
        {
            Deposit(amount);
        }
        // getters
        public decimal GetBalance()
        {
            return this._balance;
        }
        // setters
        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            _balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if(amount > _balance)
            {
                throw new InvalidOperationException("No sufficient balance");
            }
            _balance -= amount;
        }
    }
}
