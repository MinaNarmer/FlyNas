
using System;

namespace ConsoleApp1.Interfaces
{
    public interface IDAL
    {
        string AddPassenger(string passengerName, DateTime birthDate, string email);

        string CreateBooking(string passengerId, DateTime bookingDate, decimal ticketPrice);

        string GetPassenger(string email);
    }
}
