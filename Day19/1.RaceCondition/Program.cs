using System;
using System.Threading;
using System.Threading.Tasks;

static class Program
{
    static int counter = 0;

    static async Task Main(string[] args)
    {
        Task task1 = Task.Run(() => IncrementCounterAsync());
        Task task2 = Task.Run(() => IncrementCounterAsync());
        
		// jika method sudah bertype tasks pemanggilan method bisa langsung tanpa state Task.Run
        // var task3 = IncrementCounterAsync2();
        // var task4 = IncrementCounterAsync2();


        await Task.WhenAll(task1, task2);

        Console.WriteLine($"Final Counter: {counter}");
        Console.ReadKey();
    }

    static void IncrementCounterAsync()
    {
        for (int i = 0; i < 100; i++)
        {
            counter++;
            //Task.Delay(100);
            Console.WriteLine($"{i}Counter from '{Task.CurrentId}' : {counter}");
        }


    }
    // static async Task IncrementCounterAsync2()
    // {
    //     for (int i = 0; i < 100; i++)
    //     {
    //         counter++;
    //         await Task.Delay(100);
    //         Console.WriteLine($"{i}Counter from '{Task.CurrentId}' : {counter}");
    //     }
    // }
}
