namespace FactoryPattern;

public class EmployeeFactory
{
    public Employee createManager(string name)
    {
        return new Employee(name, "Manager", 12000000);
    }
    public Employee createStaff(string name)
    {
        return new Employee(name, "Staff", 7000000);
    }
    public Employee createOperator(string name)
    {
        return new Employee(name, "Operator", 5000000);
    }

}
