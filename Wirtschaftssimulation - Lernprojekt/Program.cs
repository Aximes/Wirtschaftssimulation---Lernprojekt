using System;
using Wirtschaftssimulation___Lernprojekt.System.Mathematics;

namespace Wirtschaftssimulation___Lernprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Vector2 a = new Vector2(0, 0);
            Vector2 b = new Vector2(0, 0);
            Vector2 c = a.AddLocal(new Vector2(1, 1));
            Vector2 d = b.Add(new Vector2(1, 1));

            BankAccount account = new BankAccount(10000, "Aximes", -10000);
            BankAccount account2 = new BankAccount(10000, "KI1", -10000);
            BankAccount account3 = new BankAccount(10000, "KI2", -10000);
            BankAccount account4 = new BankAccount(10000, "KI3", -10000);
            account.AddInterest(0.05m);
            account.Withdraw(21000);
            Bank bank1 = new Bank("Bank1", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Bank bank2 = new Bank("Bank2", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Bank bank3 = new Bank("Bank3", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Bank bank4 = new Bank("Bank4", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            Bank bank5 = new Bank("Bank5", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100);
            bank1.Accounts.Add(account);
            bank3.Accounts.Add(account2);
            bank4.Accounts.Add(account3);
            bank1.Accounts.Add(account4);
            Console.WriteLine(bank1.ToString());
            Console.WriteLine(bank2.ToString());
            Console.WriteLine(bank3.ToString());
            Console.WriteLine(bank4.ToString());
            Console.WriteLine(bank5.ToString());
            Console.WriteLine(account.Balance + " " + account.Owner);
            Console.WriteLine(a.x.ToString("n") + " " + a.y.ToString("n"));
            Console.WriteLine(b.x.ToString("n") + " " + b.y.ToString("n"));
            Console.WriteLine(c.x.ToString("n") + " " + c.y.ToString("n"));
            Console.WriteLine(d.x.ToString("n") + " " + d.y.ToString("n"));


            bool boolean = ConsoleIO.PromptBoolean("Möchten Sie ein neuens Konto anlegen xD", true);
            Console.WriteLine(boolean);


            int Alter = ConsoleIO.PromptNumber("Wie Alt sind Sie?", "Alter");
            Console.WriteLine(Alter);


            Vector2 Vector = ConsoleIO.PromptVector("Geben Sie bitte ihre Koordinaten an");
            Console.WriteLine(Vector);

            string pet = ConsoleIO.PromptOptions("Was ist Ihr Lieblingstier", "Lieblingstier", new string[] { "Dinosaurier", "Panther", "Bratwurst" });


            Console.ReadLine();
        }
    }
}