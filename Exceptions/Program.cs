
//Introducing EXCEPTION HANDLING
try
{

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Type a number: ");
    Console.ResetColor();
    int n1 = int.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Type another number: ");
    Console.ResetColor();
    int n2 = int.Parse(Console.ReadLine());

    int result = n1 / n2;


    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"The result is: {result}");
    Console.ResetColor();

}
catch (DivideByZeroException) //Upcasting - DivideByZero its a subclass of superclass Exception
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Division by ZERO is not allowed!");
    Console.ResetColor();
}
catch (FormatException e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Format error: ---> {e.Message}");
    Console.ResetColor();
}




//GENERIC WAY

//catch (Exception e) //Upcasting - DivideByZero its a subclass of superclass Exception
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine($"It can't be calculated. ---> {e.Message}");
//    Console.ResetColor();
//}