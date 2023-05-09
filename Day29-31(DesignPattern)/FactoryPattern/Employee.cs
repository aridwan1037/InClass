namespace FactoryPattern;

public class Employee
{
    private string _name;
    private string _title;
    private int _salary;
    
    public Employee(string name, string title, int salary)
    {
        _name = name;
        _title = title;
        _salary = salary;
    }
    
}
