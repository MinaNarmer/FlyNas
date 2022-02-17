
using System;

namespace ConsoleApp1.Interfaces
{
   public interface IBalanceService : IDisposable
    {
        decimal GetUserBalance(string email);
    }
}
