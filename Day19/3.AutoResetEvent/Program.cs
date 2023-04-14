using System.Threading.Tasks;
using System.Threading;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Main Method Started");
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        AutoResetEvent autoResetEvent1 = new AutoResetEvent(true);
        var task = Task.Run(async () =>
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Task Started");
            Task.Delay(100):
            Console.WriteLine("Task Method1");
            await Task.Run(() => autoResetEvent.WaitOne());
            Console.WriteLine("Task Method2");
            await Task.Run(() => autoResetEvent1.WaitOne());
            Console.WriteLine("Task Method3");
            Task.Delay(100):
            Console.WriteLine("Task Completed");
        });
        var task1 = Task.Run(() =>
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Task1 Started");
            Task.Delay(100):
            Console.WriteLine("Task1 Method1");
            Task.Delay(100):
            Console.WriteLine("Task1 Method2");
            autoResetEvent.Set();
            Console.WriteLine("Task1 Method3");
            Task.Delay(100):
            Console.WriteLine("Task1 Completed");
        });
        var task2 = Task.Run(() =>
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task2 Started");
            Task.Delay(100):
            Console.WriteLine("Task2 Method1");
            autoResetEvent1.Set();
            Console.WriteLine("Task2 Method2");
            Task.Delay(100):
            Console.WriteLine("Task2 Method3");
            Task.Delay(100):
            Console.WriteLine("Task2 Completed");
        });
        await Task.WhenAll(task, task1, task2);
        Console.WriteLine("All Task Done");
        Console.ReadKey();

    }
}