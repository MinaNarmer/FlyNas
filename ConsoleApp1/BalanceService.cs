using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1 {
  public class BalanceService : IBalanceService 
    {
    public void Dispose() {
    }

    public decimal GetUserBalance(string email) {
      var r = new Random();
      return r.Next(0, 10) > 5 ? 500.0M : 50M;
    }
  }
}