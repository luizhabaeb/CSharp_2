//Write a program to read data from N figures (N given by user)
// then display all those shape areas on the same order wich was typed.
using System.Globalization;
using Abstract_Class_N_Methods.Entities;
using Abstract_Class_N_Methods.Entities.ENUMs;

List<Shape> list = new List<Shape>();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Enter the number of shapes you want: ");
int n = int.Parse(Console.ReadLine());
Console.ResetColor();
Console.WriteLine();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Shape {i} data: ");
    Console.Write("Rectangle or Circle (r/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Black, Blue or Red? ");
    Color color = Enum.Parse<Color>(Console.ReadLine());
    if (ch == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Rectangle(width, height, color));
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Circle(radius, color));
    }
}

Console.WriteLine();
Console.WriteLine("SHAPE AREAS:");
foreach (Shape shape in list)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}

