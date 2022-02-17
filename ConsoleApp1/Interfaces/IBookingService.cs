
using System;

namespace ConsoleApp1.Interfaces
{
    public interface IBookingService 
    {
        (bool, string) CreateBooking(string passengerName, string birthDate, string email, string salesChannel, DateTime bookingDate);
    }
}
