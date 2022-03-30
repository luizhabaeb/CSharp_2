// Read a employee's data with 'N' contracts (N inputed by user). 
// Then calculate their salaries considering all the details and classes.
using Inheritance_Exercises;
using Inheritance_Exercises.Entities;
using System.Globalization;

List<Employee> list = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Hi. Welcome to Employees Data Program!");
Console.ResetColor();
Console.WriteLine(); Console.Write("Enter the Number of Employees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Employee {i} data: ");
    Console.ResetColor();
    Console.Write("Outsourced (y/n)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ch == 'y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("- PAYMENTS:");
Console.ResetColor();
foreach (Employee emp in list)
{
    Console.WriteLine(emp.Name + " -$ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
}







