using System.Globalization;
using FixationExercise_Interface.Entities;
using FixationExercise_Interface.Services;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Enter contract data: ");
Console.ResetColor();
Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyy): ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter the number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract myContract = new Contract(contractNumber, contractDate, contractValue);

ContractService contractService = new ContractService(new PayPalService());
contractService.ProcessContract(myContract, months);

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Installments: ");
Console.ResetColor();

foreach (Installment installment in myContract.Installments)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(installment);
    Console.ResetColor();
}



