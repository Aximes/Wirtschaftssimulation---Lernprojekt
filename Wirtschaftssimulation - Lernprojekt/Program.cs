using System;
using Wirtschaftssimulation___Lernprojekt.System.Mathematics;

namespace Wirtschaftssimulation___Lernprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 a = new Vector2(0, 0);
            Vector2 b = new Vector2(0, 0);
            Vector2 c = a.AddLocal(new Vector2(1, 1));
            Vector2 d = b.Add(new Vector2(1, 1));
            Random rnd = new Random();

            BankAccount account = new BankAccount(10000, "Aximes", -10000);
            account.AddInterest(0.05m);
            account.Withdraw(21000);
            Bank bank1 = new Bank("Bank1", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Bank bank2 = new Bank("Bank2", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Bank bank3 = new Bank("Bank3", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Bank bank4 = new Bank("Bank4", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Bank bank5 = new Bank("Bank5", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Console.WriteLine("Name: " + bank1.Name + " | Rate: " + bank1.Rate.ToString("P2") + " | Dispo: " + bank1.Dispo.ToString("n2") + " | Transaction Fee: " + bank1.TransactionFee.ToString("P2")+ " | Account Management Fee: " + bank1.AccountManagementFee.ToString("P2"));
            Console.WriteLine("Name: " + bank2.Name + " | Rate: " + bank2.Rate.ToString("P2") + " | Dispo: " + bank2.Dispo.ToString("n2") + " | Transaction Fee: " + bank2.TransactionFee.ToString("P2") + " | Account Management Fee: " + bank2.AccountManagementFee.ToString("P2"));
            Console.WriteLine("Name: " + bank3.Name + " | Rate: " + bank3.Rate.ToString("P2") + " | Dispo: " + bank3.Dispo.ToString("n2") + " | Transaction Fee: " + bank3.TransactionFee.ToString("P2") + " | Account Management Fee: " + bank3.AccountManagementFee.ToString("P2"));
            Console.WriteLine("Name: " + bank4.Name + " | Rate: " + bank4.Rate.ToString("P2") + " | Dispo: " + bank4.Dispo.ToString("n2") + " | Transaction Fee: " + bank4.TransactionFee.ToString("P2") + " | Account Management Fee: " + bank4.AccountManagementFee.ToString("P2"));
            Console.WriteLine("Name: " + bank5.Name + " | Rate: " + bank5.Rate.ToString("P2") + " | Dispo: " + bank5.Dispo.ToString("n2") + " | Transaction Fee: " + bank5.TransactionFee.ToString("P2") + " | Account Management Fee: " + bank5.AccountManagementFee.ToString("P2"));
            Console.WriteLine(account.Balance + " " + account.Owner);
        }
    }
}
