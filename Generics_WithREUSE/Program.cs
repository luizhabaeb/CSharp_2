// REUSE - Write a program which read a array with integer numbers from 1 to 10
// Then prin these numbers in a orderly way. 
// By the end, print the first value informed by the user.
// NOW USING 'OBJECT'

using Generics;

PrintService<int> printService = new PrintService<int>();

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("How many values you want to input? ");
int n = int.Parse(Console.ReadLine());
Console.ResetColor();
for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    printService.AddValue(x);
}

Console.ForegroundColor = ConsoleColor.Red;
printService.Print();
Console.ResetColor();

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("First: " + printService.First());
Console.ResetColor();