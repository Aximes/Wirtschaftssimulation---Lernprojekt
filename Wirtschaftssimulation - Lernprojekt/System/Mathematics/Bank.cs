using System;
using System.Collections;

namespace Wirtschaftssimulation___Lernprojekt.System.Mathematics
{
    class Bank
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Dispo { get; set; }
        public decimal TransactionFee { get; set; }
        public decimal AccountManagementFee { get; set; }
        public ArrayList Accounts { get; set; }

        public Bank(string Name, decimal Rate, decimal Dispo, decimal TransactionFee, decimal AccountManagementFee)
        {
            this.Name = Name;
            this.Rate = Rate;
            this.Dispo = Dispo;
            this.TransactionFee = TransactionFee;
            this.AccountManagementFee = AccountManagementFee;
        }
    }
}