using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1 {
  public  class DAL : IDAL
    {
    public  string AddPassenger(string passengerName, DateTime birthDate, string email) {
      var newPassengerId = Guid.NewGuid().ToString();
      //data access code
      return newPassengerId;
    }

    public  string CreateBooking(string passengerId, DateTime bookingDate, decimal ticketPrice) {
      var bookingNumber = Guid.NewGuid().ToString();
      //data access code
      return bookingNumber;
    }

    public  string GetPassenger(string email) {
      //data access code
      return Guid.NewGuid().ToString();
    }
  }
}