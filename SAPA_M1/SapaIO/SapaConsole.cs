using System;

namespace SapaIO
{
    public static class SapaConsole
    {
        public static void Write(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ResetColor();
        }

        public static void WriteLine(string msg, ConsoleColor color)
        {
            Write(msg+Environment.NewLine, color);
        }
    }
}
