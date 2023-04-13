using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //		Task task = new Task(() => Console.WriteLine("Hello, Task Start!"));
        //		task.Start();
        //		task.Wait(); // Wait for the task to complete
        //
        //		Task task1 = Task.Run(() => Console.WriteLine("Hello, Task.Run!"));
        //		task1.Wait(); // Wait for the task to complete
        //		
        int a = 5;
        int b = 7;
        Task<int> tAdd = Task.Run(() => Add(a, b));
        Task<int> tMul = Task.Run(() => Mul(a, b));
        int result1 = tAdd.Result;
        int result2 = tMul.Result;
        int z = Add(result1, result2);
        Console.WriteLine(result1); // Same as above
        Console.WriteLine(result2); // Same as above
        Console.WriteLine(z);
    }
    public static int Add(int a, int b) => a + b;
    public static int Mul(int a, int b) => a * b;
}
