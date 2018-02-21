using System;
using System.Collections.Generic;

namespace Wirtschaftssimulation___Lernprojekt.System.Mathematics
{
    class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Dispo { get; set; }
        public decimal TransactionFee { get; set; }
        public decimal AccountManagementFee { get; set; }

        public List<BankAccount> Accounts { get; set; }
        public List<Bank> Banks { get; set; }

        public Boolean IsPlayerBank { get; set; }

        public Bank( int id, string Name, decimal Rate, decimal Dispo, decimal TransactionFee, decimal AccountManagementFee)
        {
            this.Id = id;
            this.Name = Name;
            this.Rate = Rate;
            this.Dispo = Dispo;
            this.TransactionFee = TransactionFee;
            this.AccountManagementFee = AccountManagementFee;
            this.Accounts = new List<BankAccount>();
            this.IsPlayerBank = false;
        }

        public void setPlayerBank()
        {
            this.IsPlayerBank = true;
        }
    }
}