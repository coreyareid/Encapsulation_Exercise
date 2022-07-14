using System;
namespace Encapsulation_Exercise
{
    public class BankAccount
    {
        // Default Contructor
        public BankAccount()
        {
        }

        // Fields
        private double balance = 0;

        // Properties
        // public double Balance { get; set; }


        // Methods
        public void Deposit(double amount)
        {
            balance += amount;
        }


        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}

