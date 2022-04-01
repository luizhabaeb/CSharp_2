using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolvingAProblem_Exception.Entities.Exceptions;


namespace SolvingAProblem_Exception.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }


        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date!"); //throw - lança a exceção
            }

            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public double Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn); //TimeSpan > Duração // Subtract diferença entre um instante e outro
            return (int)duration.TotalDays;
        }
        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates"); //throw - lança a exceção
            }
            else if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date"); //throw - lança a exceção
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return "The Room is "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}


