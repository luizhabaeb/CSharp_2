using System.Globalization;
using Exercise_Products.Entities;

List<Product> list = new List<Product>(); //NUNCA ESQUECER DE CRIAR A LISTA

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Welcome to Products Data Program!");
Console.WriteLine();
Console.ResetColor();
Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Product {i} data: ");
    Console.ResetColor();
    Console.Write("Common, Used or Imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ch == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (ch == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, date));
    }
    else
    {
        Console.Write("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(name, price, customsFee));
    }
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-> PRICE TAGS:");
Console.ResetColor();
foreach (Product p in list)
{
    Console.WriteLine(p.PriceTag());
}
