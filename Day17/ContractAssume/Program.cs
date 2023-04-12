using System.Diagnostics.Contracts;

class Program
{
    static void Main()
{
        int x = 10;
        int y = 20;
        // Using Contract.Assert
        Contract.Assert(x == 10, "x must be 10");

        // Using Contract.Assume
        Contract.Assume(y < 10, "y must be greater than 10");
    }
}