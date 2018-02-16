using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Wirtschaftssimulation___Lernprojekt.System.Mathematics;

namespace Wirtschaftssimulation___Lernprojekt.System.Mathematics
{
    class Bank
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Dispo { get; set; }
        public decimal TransactionFee { get; set; }
        public decimal AccountManagementFee { get; set; }
        public List<BankAccount> Accounts { get; set; }

        public Bank(string Name, decimal Rate, decimal Dispo, decimal TransactionFee, decimal AccountManagementFee)
        {
            this.Name = Name;
            this.Rate = Rate;
            this.Dispo = Dispo;
            this.TransactionFee = TransactionFee;
            this.AccountManagementFee = AccountManagementFee;
            this.Accounts = new List<BankAccount>();
        }

        public override string ToString()
        {
            return String.Format("Name:\t\t\t {0}\n Rate:\t\t\t {1}\n Dispo:\t\t\t {2} EUR\n Transaction Fee:\t {3}\n Account Management Fee: {4}\n", Name, Rate.ToString("P2"), Dispo.ToString("N2"), TransactionFee.ToString("P2"), AccountManagementFee.ToString("P2"));
        }
    }
}