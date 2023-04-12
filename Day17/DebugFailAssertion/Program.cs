using System.Diagnostics;

class Program
{
    static void Main()
    {
        int x = 10;
        int y = 20;

        // Using the Fail method
        Debug.Fail("This is a forced failure.");

        // Using the Assert method
        Debug.Assert(x < y, "x should be less than y.");
        Debug.WriteLine("This is a test");


        // The following line will trigger an assertion failure
        Debug.Assert(x > y, "x should be greater than y.");
    }
}