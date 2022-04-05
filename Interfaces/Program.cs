using System.Globalization;
using INTERFACES__Solution_With_Interface.Entities;
using INTERFACES__Solution_With_Interface.Services;


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Enter rental data: ");
Console.ResetColor();

Console.Write("Car model: ");
string model = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


CarRental carRental = new CarRental(start, finish, new Vehicle(model));
RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
rentalService.ProcessInvoice(carRental);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("INVOICE: ");
Console.ResetColor();
Console.WriteLine(carRental.Invoice);

