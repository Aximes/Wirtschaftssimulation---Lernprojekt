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
            Console.WriteLine("Transaktion wird durchgeführt!");
            Console.WriteLine(Balance + " + " + Anmount);
            Balance += Anmount;
            Console.WriteLine("Ihr neuer Saldo beträgt: " + Balance + " EUR");
            Console.WriteLine(Anmount + " wurde erfolgreich auf Ihr Konto überwiesen!");
            return true;
        }

        public bool Withdraw(decimal Anmount)
        {
            if (Balance - Anmount > Dispo)
            {
                Console.WriteLine("Transaktion wird durchgeführt!");
                Console.WriteLine(Balance + " - " + Anmount);
                Balance -= Anmount;
                Console.WriteLine("Ihr neuer Saldo beträgt: " + Balance +" EUR");
                Console.WriteLine(Anmount + " wurde erfolgreich vom Konto abgehoben!");
                return true;
            }
            else
            {
                ConsoleIO.PrintColoredLine("Ihr Konto ist nicht ausreichend gedeckt!", ConsoleColor.DarkRed);
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