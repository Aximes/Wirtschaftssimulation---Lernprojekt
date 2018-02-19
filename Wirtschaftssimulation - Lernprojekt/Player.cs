using System;
using System.Collections.Generic;
using Wirtschaftssimulation___Lernprojekt.System.Mathematics;

namespace Wirtschaftssimulation___Lernprojekt
{
    class Player : IPlayer
    {
        public string Diff { get; set; }
        public string Sex { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CompanyName { get; set; }
        //public List<Worker> Workers { get; set; }
        //public List<Vehicle> Vehicles { get; set; }
        //public List<Building> Buildings { get; set; }
        public List<BankAccount> Accounts { get; set; }
        public List<Bank> Banks { get; set; }
        //public List<CompanyShare> CompanyShares { get; set; 

        public Player(string diff, string sex, string name, int age, string companyName)
        {
            this.Diff = diff;
            this.Sex = sex;
            this.Name = name;
            this.Age = age;
            this.CompanyName = companyName;
            //this.Workers = new List<Worker>();
            //this.Vehicles = new List<Vehicle>();
            //this.Buildings = new List<Building>();
            this.Accounts = new List<BankAccount>();
            this.Banks = new List<Bank>();
            //this.CompanyShares = new List<CompanyShare>;
        }
    }
}
