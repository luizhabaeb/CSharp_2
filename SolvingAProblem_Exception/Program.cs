//Write a program to read a hotel reservation data (including room number, checkin, checkout) and display the reservation data, including the duration (days).
//Then read new checkin and checkouts, update the reserve and display again the reservation data updated.
//The program should not allow invalid data to the reserve, according to the following rules:
// - Reservation changes only can be occurred to future date.
// - The departure date must be bigger then the entrance date.

using SolvingAProblem_Exception.Entities.Exceptions;
using SolvingAProblem_Exception.Entities;

try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkout = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);
}
catch (FormatException e)
{
    Console.WriteLine("Error in format: " + e.Message);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}
 