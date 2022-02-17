

using System;

namespace ConsoleApp1.Interfaces
{
    public interface IPaymentService : IDisposable
    {
        bool RequestPayment(string email, decimal price);
    }
}
