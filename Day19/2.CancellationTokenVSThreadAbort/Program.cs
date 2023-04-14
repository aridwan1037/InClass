using System;
using System.Threading.Tasks;
using System.Threading;

static class Program {
	static void Main() 
	{
		Thread myThread = new Thread(DoLongRunningLoop);
		
		if (Console.ReadKey().KeyChar == ' ') 
		{
			myThread.Abort();
		}
		
		try
		{
			myThread.Join();
		}
		catch (Exception) 
		{
			Console.WriteLine("Operation Abort");
		}
		finally 
		{
			Console.WriteLine("Running Loop Finished");
		}
	}
	static void DoLongRunningLoop()
	{
		for (int i = 0; i < 100; i++) 
		{
			Console.WriteLine($"Task : {i} % ");
			Thread.Sleep(100);
		}
		Console.WriteLine($"Thread Completed");
	}
}