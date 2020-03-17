using System;

namespace Lab1
{
    class BankAccount
    {
        private int id;
        private decimal balance = 0;
        BankAccount(int id, decimal balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public void print()
        {
            Console.WriteLine("The ID: " + id);
            Console.WriteLine("The balance: " + balance);

        }

        public void Withdraw(decimal withdraw)
        {
            balance = balance - withdraw;
            Console.WriteLine("Withdraw: " + withdraw);
            Console.WriteLine("Current amount in the account: " + balance);
            if (!Money())
            {
                balance = 0;
                Console.WriteLine("Your Account is Empty");
            }
        }

        public void Deposit(decimal deposit)
        {
            balance = balance + deposit;
            Console.WriteLine("Sent: " + deposit);
            Console.WriteLine("Current amount in the account: " + balance);
        }

        public bool Money()
        {
            return balance >= 0;
        }

        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount(1, 12);
            acc.print();
            acc.Deposit(5);
            acc.Withdraw(7);
        }
    }
}
