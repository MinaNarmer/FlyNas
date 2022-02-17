using Autofac;
using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1 {
  class Program {
    static void Main(string[] args) {
            var cont = BuildContainer();
           var bookingService = cont.Resolve<IBookingService>();
      (bool success1, string bookingRef1) = bookingService.CreateBooking(
        "Ahmed",
        "2000-09-13",
        "someEmail@some.com",
        "website",
        DateTime.Now);
      
      Console.WriteLine("Ahmed " + (success1 ? "succeeded" : "failed") + " to book on " + DateTime.Now.ToString());
            Console.ReadLine();


            (bool success2, string bookingRef2) = bookingService.CreateBooking(
        "Ahmed",
        "2000-09-13",
        "someEmail@some.com",
        "mobile",
        new DateTime(2021, 12, 13));
      
      Console.WriteLine("Ahmed " + (success2 ? "succeeded" : "failed") + " to book on " + new DateTime(2021, 12, 13).ToString());


      Console.ReadLine();
    }


        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PaymentService>().As<IPaymentService>();
            builder.RegisterType<BalanceService>().As<IBalanceService>();
            builder.RegisterType<PriceService>().As<IPriceService>();
            builder.RegisterType<BookingService>().As<IBookingService>();
            builder.RegisterType<DAL>().As<IDAL>();
            builder.RegisterType<SalesChannelFactory>().As<ISalesChannelFactory>();

            return builder.Build();
        }
    }
}