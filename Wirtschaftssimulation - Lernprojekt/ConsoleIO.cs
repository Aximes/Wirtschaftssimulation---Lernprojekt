using System;
using System.Linq;
using Wirtschaftssimulation___Lernprojekt.System.Mathematics;

namespace Wirtschaftssimulation___Lernprojekt
{
#pragma warning disable CS0168
    class ConsoleIO : IUserControl
    {
        public string PromptString( string prompt, string type )
        {
            Console.WriteLine(prompt);
            Console.Write(type+": ");
            string text = Console.ReadLine();
            while (text.Equals(""))
            {
                Console.Write(type+": ");
                text = Console.ReadLine();
            }
            return text;
        }

        public int PromptNumber( string prompt, string type )
        {
            Console.WriteLine(prompt);
            string text;
            int zahl;
            while (true)
            {
                Console.Write(type+": ");
                text = Console.ReadLine();
                try
                {
                    zahl = Convert.ToInt32(text);
                    break;
                }
                catch (Exception e)
                {
                    // Do nothing
                }
            }
            return zahl;
        }

        public string PromptOptions( string prompt, string type, string[] options )
        {
            Console.WriteLine(prompt);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
            }
            string text;
            while (true)
            {
                Console.Write(type + ": ");
                text = Console.ReadLine();
                if (options.Contains(text))
                    return text;
            }
        }

        public string PromptList(string prompt, string type, string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("[" + (i+1) + "]\t" + list[i]);
            }
            int number;
            while ( true )
            {
                try
                {
                    number = PromptNumber(prompt, type);
                    return (list[number - 1]);
                }
                catch (Exception e)
                {
                    // Do nothing
                }
            } 
        }

        public bool PromptBoolean( string prompt, Boolean defaultValue )
        {
            Console.Write(prompt + " " + (defaultValue ? "[Y|n]: " : "[y|N]: "));
            while (true)
            {
                ConsoleKeyInfo ret = Console.ReadKey(true);
                if (ret.KeyChar == 'y')
                {
                    Console.WriteLine("y");
                    return true;
                }
                if (ret.KeyChar == 'n')
                {
                    Console.WriteLine("n");
                    return false;
                }
                if (ret.KeyChar == '\n' || ret.KeyChar == '\r')
                {
                    Console.WriteLine(defaultValue ? "y" : "n");
                    return defaultValue;
                }
            }
        }

        public string PromptCommand( string prompt, string[] commands )
        {
            string text;
            while (true)
            {
                Console.Write(prompt + ": ");
                text = Console.ReadLine();
                if (commands.Contains(text))
                    return text;
            }
        }

        public Vector2 PromptVector(string prompt)
        {
            Console.WriteLine(prompt);
            string text;
            Vector2 vector;
            while (true)
            {
                Console.Write( "Koordinaten [x, y]: " );
                text = Console.ReadLine();
                try
                {
                    string[] parts = text.Split(',');
                    if(parts.Length != 2)
                    {
                        continue;
                    }
                    vector = new Vector2(Convert.ToDouble(parts[0]), Convert.ToDouble(parts[1]));
                    break;
                }
                catch (Exception e)
                {
                    // Do nothing
                }
            }
            return vector;
        }

        public void PrintColored( string message, ConsoleColor color )
        {
            ConsoleColor current = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = current;
        }
        
        public void PrintColoredLine( string message, ConsoleColor color )
        {
            ConsoleColor current = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = current;
        }
    }
#pragma warning restore CS0168
}
