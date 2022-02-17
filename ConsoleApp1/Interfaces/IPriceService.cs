
using System;

namespace ConsoleApp1.Interfaces
{
   public interface IPriceService : IDisposable
    {
        decimal GetNormalPrice(DateTime bookingDate);

        decimal GetLowestPrice(DateTime bookingDate);
    }
}
