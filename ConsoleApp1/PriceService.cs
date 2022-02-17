using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1 {
  public class PriceService : IPriceService
    {
    public decimal GetNormalPrice(DateTime bookingDate) {
      //do some calculations
      return 100M;
    }

    public decimal GetLowestPrice(DateTime bookingDate) {
      //do some calculations
      return 90M;
    }

    public void Dispose() {
    }
  }
}