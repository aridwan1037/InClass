namespace FactoryPattern;
internal class Program
{
    private static void Main(string[] args)
    {
        // var manager1 = new Employee("joko", "manager", 12000000);
        // var manager2 = new Employee("bambang", "manager", 12000000);
        // var staff1 = new Employee("candra", "staff", 7000000);
        // var staff2 = new Employee("gilang", "staff", 7000000);
        // var operator1 = new Employee("rudi", "operator", 5000000);
        EmployeeFactory employeeFactory = new EmployeeFactory();
        Employee manager1 = employeeFactory.createManager("joko");
        Employee manager2 = employeeFactory.createManager("bambang");
        Employee staff1 = employeeFactory.createStaff("candra");
        Employee staff2 = employeeFactory.createStaff("gilang");
        Employee operator1 = employeeFactory.createOperator("rudi");
        
    }
}