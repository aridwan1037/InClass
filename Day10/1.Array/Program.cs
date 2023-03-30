//Pembuatan Array dari object dan menampilkannya
internal class Program
{
    private static void Main(string[] args)
    {
        //emp 1-4 pada dasarnya adalah semacam diclare 
        //nilai dari suatu variable Employee(string) dan valuenya
        Employee emp1 = new Employee("John");
        Employee emp2 = new Employee("Mary");
        Employee emp3 = new Employee("Peter");
        Employee emp4 = new Employee("Mike");

        //pembuatan array dari type data Employee(string)
        //penulisan lebih singkatnya adalah string[] employees = {"jhon", "Mary", "Peter", "Mike};
        Employee[] employees = { emp1, emp2, emp3, emp4 };

        //pembuatan array cara kedua menentukan maksimal indeks array terlebih dahulu
        Employee[] employees2 = new Employee[4];
        employees2[0] = emp1;
        employees2[1] = emp2;
        employees2[2] = emp3;
        employees2[3] = emp4;

        //cara ketiga langung declare value pada saat pembuaran array dari type data Employee[]
        Employee[] employees3 = new[] { emp1, emp2, emp3, emp4 };

        Console.WriteLine($"1. employee name: {employees[0].Name}");
        Console.WriteLine($"2. employee name: {employees[1].Name}");
        Console.WriteLine($"3. employee name: {employees[2].Name}");
        Console.WriteLine($"4. employee name: {employees[3].Name}");

        string[] arrstring = { "joni", "budi", "samsudi", "ricard" };
        foreach (string str in arrstring)
        {
            Console.WriteLine(str);
        }

        foreach (var employee in employees2)
        {
            Console.WriteLine($"Employee Name from 2nd array : {employee}");
        }
        // for(int i; i <= employees3.Length-1; i++)
        // {
        //     Console.WriteLine($"Employee Name from 3rd array : {employees3[i].Name}");
        // }
        // Array.Sort(employees, (x, y) => x.Name.CompareTo(y.Name));
		// 	Array.Sort(employees2, CompareEmployeesByName);
		// 	foreach (var employee in employees)
		// 	{
		// 		Console.WriteLine($"{employee.Name}");
			// }
        // Console.WriteLine($"Employee name is = {employees[0].Name}");

    }
}
class Employee
{
    public string Name { get; set; }
    public Employee(string name)
    {
        Name = name;

    }
}