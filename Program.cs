using System;

namespace MesFinances
{
    class Program
    {
        static void Main(string[] args)
        {
            var couleur = Console.ForegroundColor;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("+-----------------------------+\n");
            Console.Write("|         Mes Finances        |\n");
            Console.Write("+-----------------------------+\n");
            Console.Write("\n");
            Console.Write("+-----------------------------+\n");
            Console.Write("|            Login            |\n");
            Console.Write("+-----------------------------+\n");
            Console.Write("| User : ");
            string user = Console.ReadLine();
            Console.Write("| Password : ");
            string pass ="";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if(key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);
            
            
        }
    }
}
