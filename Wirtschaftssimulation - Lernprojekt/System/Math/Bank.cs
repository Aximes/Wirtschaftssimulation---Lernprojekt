﻿using System;
using System.Collections;

namespace Wirtschaftssimulation___Lernprojekt.System.Math
{
    class Bank
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Dispo { get; set; }
        public decimal TransactionFee { get; set; }
        public decimal AccountManagmentFee { get; set; }
        public ArrayList Accounts { get; set; }

        public Bank(string Name, decimal Rate, decimal Dispo, decimal TransactionFee, decimal AccountManagmentFee)
        {
            this.Name = Name;
            this.Rate = Rate;
            this.Dispo = Dispo;
            this.TransactionFee = TransactionFee;
            this.AccountManagmentFee = TransactionFee;
        }
    }
}
