using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1 {
  public class PaymentService : IPaymentService
    {
    public bool RequestPayment(string email, decimal price) {
      var r = new Random();
      return r.Next(0, 10) > 5;
    }

    public void Dispose() {
    }
  }
}