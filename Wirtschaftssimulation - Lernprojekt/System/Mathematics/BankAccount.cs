using System;

namespace Wirtschaftssimulation___Lernprojekt.System.Mathematics
{
    class BankAccount
    {
        public decimal Balance { get; set; }
        public string Owner { get; set; }
        public decimal Dispo { get; set; }
        public BankAccount(decimal Balance, string Owner, decimal Dispo)
        {
            this.Balance = Balance;
            this.Owner = Owner;
            this.Dispo = Dispo;
        }

        public bool Deposit(decimal Anmount)
        {
            Balance += Anmount;
            return true;
        }

        public bool Withdraw(decimal Anmount)
        {
            if (Balance - Anmount > Dispo)
            {
                Balance -= Anmount;
                Console.WriteLine("Transaktion erfolgreich!");
                return true;
            }
            else
            {
                Console.WriteLine("Ihr Konto ist nicht ausreichend gedeckt!");
                return false;
            }
        }

        public bool AddInterest(decimal Rate)
        {
            Balance += (Balance * Rate);
            return true;
        }
    }
}