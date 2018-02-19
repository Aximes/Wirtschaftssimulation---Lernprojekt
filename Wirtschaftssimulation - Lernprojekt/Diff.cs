using System;

namespace Wirtschaftssimulation___Lernprojekt
{
    class Diff
    {
        public string Difficulty { get; set; }
        public decimal DiffStartMoney { get; set; }
        public Diff(string Difficulty)
        {
            this.Difficulty = Difficulty;
            GetDifficultStartMoney();
        }

        public void GetDifficultStartMoney ()
        {
            if (this.Difficulty == "Leicht")
            {
                this.DiffStartMoney += 100000;
            }
            if (this.Difficulty == "Normal")
            {
                this.DiffStartMoney += 60000;
            }
            if (this.Difficulty == "Schwer")
            {
                this.DiffStartMoney += 40000;
            }
            if (this.Difficulty == "Tycoon")
            {
                this.DiffStartMoney += 25000;
            }
            if (this.Difficulty == "Unfair")
            {
                this.DiffStartMoney += 10000;
            }
        }
    }
}

