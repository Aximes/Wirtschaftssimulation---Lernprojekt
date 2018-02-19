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
            this.Balance = 0;
            this.Owner = Owner;
            this.Dispo = Dispo;
        }

        public bool Deposit(decimal Anmount)
        {
            Console.WriteLine("Transaktion wird durchgeführt!");
            Balance += Anmount;
            Program.IO.PrintColoredLine(Anmount.ToString("N2") + " wurde erfolgreich auf Ihr Konto überwiesen!", ConsoleColor.Green);
            Console.WriteLine("Ihr neuer Saldo beträgt: " + Balance.ToString("N2") + " EUR");
            return true;
        }

        public bool Withdraw(decimal Anmount)
        {
            if (Balance - Anmount > Dispo)
            {
                Console.WriteLine("Transaktion wird durchgeführt!");
                Balance -= Anmount;
                Program.IO.PrintColoredLine(Anmount.ToString("N2") + " wurde erfolgreich auf Ihr Konto überwiesen!", ConsoleColor.Green);
                Console.WriteLine("Ihr neuer Saldo beträgt: " + Balance.ToString("N2") +" EUR");
                return true;
            }
            else
            {
                Program.IO.PrintColoredLine("Ihr Konto ist nicht ausreichend gedeckt!", ConsoleColor.DarkRed);
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