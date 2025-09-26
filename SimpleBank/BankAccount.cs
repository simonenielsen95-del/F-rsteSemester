using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        private string name;
        private double balance;
        private bool locked;

        public string Name
        {  
           get { return name; } 
           set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public BankAccount(double balance)
        {
            this.balance = balance;
        }


        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;

        }

        public BankAccount(string name, double balance, bool locked)
        {
            this.name = name;
            this.balance = balance;
            this.locked = locked;
        }

        public void Deposit(double amount)
        {
            if (!locked)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Du er låst fra din konto");
            }
            
        }


        public void Withdraw(double amount)
        {
            if (!locked)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("Der er ikke nok penge på din konto!");
                }

            }
        
        }
        
        public void ChangeLockState()
        {
            locked =  !locked;
        }

        public override string ToString()
        {
            return $"Name: {name}, Balance: {balance}";
        }
        
    }
}
