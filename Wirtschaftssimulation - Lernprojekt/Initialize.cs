using System;
using System.Linq;
using Wirtschaftssimulation___Lernprojekt.System.Mathematics;

namespace Wirtschaftssimulation___Lernprojekt
{
#pragma warning disable IDE1006
    class Initialize
    {
        public static readonly IUserControl IO = new ConsoleIO();

        public string difficulty { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string companyName { get; set; }
        public string gameDifficulty { get; set; }
        public decimal playerAccount { get; set; }
        public decimal DiffStartMoney { get; set; }

        public Initialize()
        {
            string assignedBank = "";
            this.difficulty = difficulty;
            this.sex = sex;
            this.name = name;
            this.age = age;
            this.companyName = companyName;
            BankStore bStore = new BankStore();
            BankAccount account2 = new BankAccount(10000, "KI1", -10000);
            BankAccount account3 = new BankAccount(10000, "KI2", -10000);
            BankAccount account4 = new BankAccount(10000, "KI3", -10000);

            while (true)
            {
                string difficulty = IO.PromptList("Wählen Sie einen Schwierigkeitsgrad.", "Schwierigkeitsgrad", new String[] { "Leicht", "Normal", "Schwer", "Tycoon", "Unfair" });
                Console.WriteLine("\n[" + difficulty + "] ");
                this.difficulty = difficulty;

                string sex = IO.PromptList("Geben Sie Ihr Geschlecht an.", "Geschlecht", new String[] { "Männlich", "Weiblich" });
                Console.WriteLine("\n[" + difficulty + "] " + " '" + sex + "' ");
                this.sex = sex;

                string name = IO.PromptString("Geben Sie Ihren Namen an.", "Name");
                Console.WriteLine("\n[" + difficulty + "] " + " '" + sex + "' " + " " + name);
                this.name = name;

                int age = IO.PromptNumber("Geben Sie ihr Alter an.", "Alter");
                Console.WriteLine("\n[" + difficulty + "] " + " '" + sex + "' " + " " + name + " " + "(" + age + ")");
                this.age = age;

                string companyName = IO.PromptString("Geben Sie Ihren Firmennamen an.", "Firmenname");
                Console.WriteLine("\n[" + difficulty + "] " + " '" + sex + "' " + " " + name + " " + "(" + age + ")" + " <" + companyName + "> \n");
                this.companyName = companyName;

                string currentBank = IO.PromptList("Geben Sie eine Bank an, bei der Sie ihr Startkonto eröffnen möchten", "Bank", bStore.Banks.Select(b => b.Name + "\nRate: " + b.Rate.ToString("P2") + "\t| Dispo: " + b.Dispo.ToString("N2") + "\t| Transaction Fee: " + b.TransactionFee.ToString("P2") + "\t| Account Management Fee: " + b.AccountManagementFee.ToString("P2") + "\n").ToArray());
                foreach (Bank b in bStore.Banks)
                {
                    if (b.Name == currentBank)
                    {

                        break;
                    }
                }

                bool InitAccept = IO.PromptBoolean("\nSie haben die Schwierigkeit " + difficulty + " gewählt, sind '" + sex + "', heißen " + name + " und sind " + age + " Jahre alt.\nIhre Firma hat den Namen " + companyName + " und ihr Firmenkonto wurde bei der " + assignedBank + " gegründet.\nMöchten Sie bestätigen?: ", true);
                if (InitAccept == true)
                {
                    break;
                }
                Console.Clear();
            }
            Diff gameDifficulty = new Diff(difficulty);
            BankAccount PlayerAccount = new BankAccount(0, name, -10000);

            Player player1 = new Player(difficulty, sex, name, age, companyName);
            Console.WriteLine("\nIhr Konto bei der '" + assignedBank + "' wurde eröffnet, " + (sex == "Männlich" ? "Herr " : "Frau ") + name);
            PlayerAccount.Deposit(gameDifficulty.DiffStartMoney);

            Console.WriteLine("\nHerzlichen Glückwunsch, " + (sex == "Männlich" ? "Herr " : "Frau ") + name + " Sie haben erfolgreich ihre Firma " + companyName + " gegründet.");

            Console.ReadLine();
        }
    }
#pragma warning restore IDE1006
}
