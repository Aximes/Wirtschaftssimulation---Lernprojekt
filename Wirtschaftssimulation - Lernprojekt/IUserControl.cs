using System;
using Wirtschaftssimulation___Lernprojekt.System.Mathematics;

namespace Wirtschaftssimulation___Lernprojekt
{
    interface IUserControl
    {
        string PromptString(string prompt, string type);
        int PromptNumber(string prompt, string type);
        string PromptOptions(string prompt, string type, string[] options);
        string PromptList(string prompt, string type, string[] list);
        bool PromptBoolean(string prompt, Boolean defaultValue);
        string PromptCommand(string prompt, string[] commands);
        Vector2 PromptVector(string prompt);
        void PrintColored(string message, ConsoleColor color);
        void PrintColoredLine(string message, ConsoleColor color);
    }
}
