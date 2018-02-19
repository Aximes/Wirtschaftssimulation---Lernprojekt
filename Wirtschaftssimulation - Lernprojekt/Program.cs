using System;
using Wirtschaftssimulation___Lernprojekt.System.Mathematics;
using Wirtschaftssimulation___Lernprojekt.System.Interfaces;

namespace Wirtschaftssimulation___Lernprojekt
{
    class Program
    {

        public static readonly IUserControl IO = new ConsoleIO();

        static void Main(string[] args)
        {
            //Teststuff
            Vector2 a = new Vector2(0, 0);
            Vector2 e = new Vector2(0, 0);
            Vector2 c = a.AddLocal(new Vector2(1, 1));
            Vector2 d = e.Add(new Vector2(1, 1));

            Initialize init = new Initialize();
        }
    }
}