using System;
using Wirtschaftssimulation___Lernprojekt.System.Math;

namespace Wirtschaftssimulation___Lernprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 a = new Vector2(1, 0);
            Vector2 b = new Vector2(0, 1);
            Vector2 c = a.Add(b);

            BankAccount account = new BankAccount(10000, "Aximes", -10000);
            account.AddInterest(0.05m);
            account.Withdraw(21000);
            Console.WriteLine(account.Balance + " " + account.Owner);
        }
    }
}
