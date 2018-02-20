using System;
using System.Collections.Generic;

namespace Wirtschaftssimulation___Lernprojekt.System.Mathematics
{
    class BankStore
    {
        Random rnd = new Random();
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Dispo { get; set; }
        public decimal TransactionFee { get; set; }
        public decimal AccountManagementFee { get; set; }
        public List<Bank> Banks { get; set; }

        public BankStore()
        {
            this.Banks = new List<Bank>
            {
                new Bank("Bank1", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100),
                new Bank("Bank2", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100),
                new Bank("Bank3", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100),
                new Bank("Bank4", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100),
                new Bank("Bank5", rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100)
            };
        }

        public List<Bank> GetBanks()
        {
            return this.Banks;
        }
    }
}


//b.Name + "\nRate: " + b.Rate.ToString("P2") + "\t| Dispo: " + b.Dispo.ToString("N2") + "\t| Transaction Fee: " + b.TransactionFee.ToString("P2") + "\t| Account Management Fee: " + b.AccountManagementFee.ToString("P2") + "\n"
