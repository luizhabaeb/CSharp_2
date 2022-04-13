using System.Globalization;
using Restriction_Generics.Services;
using Restriction_Generics.Entities;
using System.Collections.Generic;


List<Product> list = new List<Product>();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(',');
    string name = vect[0];
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
    list.Add(new Product(vect[0], price));
}
Console.ResetColor();

CalculationService calculationService = new CalculationService();  //instancio meu serviço
Product max = calculationService.Max(list);  //chamo a função MAX e passo minha lista como argumento

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"The most expensive product is: {max}");
Console.ResetColor();
