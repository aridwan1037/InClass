using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Here's an example of formatted console output:");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("This text is ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("yellow");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(" on a ");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("dark magenta");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" background");

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Here are some other formatting options:");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Red text ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("with green text ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("and yellow text ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("and blue text.");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write("Bold, underlined, and italicized text");
        Console.ResetColor();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("You can also change the font size by changing the console buffer size:");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("This text has a larger font size");
        Console.WindowWidth = Console.LargestWindowWidth / 2;
        Console.WindowHeight = Console.LargestWindowHeight / 2;
        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight * 2;
        Console.WriteLine("This text has a smaller font size");

        Console.ResetColor();
    }
}
