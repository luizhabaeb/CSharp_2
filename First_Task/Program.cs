// Read a employee's data with 'N' contracts (N inputed by user). 
// Then ask a Month to the user and display which one was the employee's salary on this month.
using First_Task_Employee.Entities.Enumerators;
using First_Task_Employee;
using First_Task_Employee.Entities;
using System.Globalization;


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Hi. Welcome to Employees Data Program!");
Console.ResetColor();
Console.WriteLine();Console.Write("Enter the department's name: ");
string deptName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("What's your level? (Junior, Full or Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base Salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new Department(deptName);
Worker worker = new Worker(name, level, baseSalary, dept);


Console.Write("How many contracts to this worker? → ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data: ");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);   
}
Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));  //recortar a partir da posição 0 > 2 caracteres
int year = int.Parse(monthAndYear.Substring(3));     //recortar da posição 3 em diante, como coloco só um número, ele corta até o final
Console.WriteLine($"Name: {worker.Name} ");
Console.WriteLine($"Department: {worker.Department.Name} "); //Navegacao entre objetos
Console.WriteLine($"Income for {monthAndYear}: " + " " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();









