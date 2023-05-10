using GetAFreshView;
internal class Program
{
    private static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        int a = 5;
        int b = 3;
        int add = cal.Add(a, b);
        int sub = cal.Sub(a, b);
        int mul = cal.Mul(a, b);

        Console.WriteLine($" Addition Method Result = {add} ");
        Console.WriteLine($" Subtraction Method Result = {sub}");
        Console.WriteLine($" Multiplication Method Result = {mul}");
        
    }
}