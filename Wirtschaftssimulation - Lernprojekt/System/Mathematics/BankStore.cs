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
        public List<String> BankNameList { get; set; }

        public BankStore()
        {
            this.Banks = new List<Bank>();
            this.BankNameList = new List<String>
            {
                "Spaßkasse",
                "Pfostenbank",
                "CommerzGandals",
                "Lauchtresor",
                "DagobertDuck"
            };

            FilledBanks(5);
        }

        public void FilledBanks(Int32 Anzahl)
        {
            for(int i = 1; i <= Anzahl; i++)
            {
                this.Banks.Add(new Bank(i, this.BankNameList[i-1], rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 30) * 1000, rnd.Next(1, 11) / (decimal)100, rnd.Next(1, 11) / (decimal)100));
            }
        }

        public Bank getBankByID(int id)
        {
            return Banks[id-1];
        }
    }
}