using System;
using System.Collections;
using System.Collections.Generic;

namespace Wirtschaftssimulation___Lernprojekt.System.Mathematics
{
    interface IPlayer
    {
        string Diff { get; set; }
        string Sex { get; set; }
        int Age { get; set; }
        string Name { get; set; }
        string CompanyName { get; set; }
        List<BankAccount> Accounts { get; set; }
        List<Bank> Banks { get; set; }
        int BankID { get; set; }
    }
}
