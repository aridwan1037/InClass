using System.Net.NetworkInformation;
using System.Data;
internal class Program
{
    private static void Main(string[] args)
    {
        DateTime newDate = DateTime.Now;
        Console.WriteLine(newDate.ToString());
        
        DateTime tomorrow = newDate.AddDays(1);
        Console.WriteLine(tomorrow.ToString());

        Console.WriteLine(newDate.ToString("d"));
        Console.WriteLine(newDate.ToString("D"));
        Console.WriteLine(newDate.ToString("t"));
        Console.WriteLine(newDate.ToString("T"));
        Console.WriteLine(newDate.ToString("a"));

    }
}