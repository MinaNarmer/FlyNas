using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1
{
    public class BookingService : IBookingService
    {

        private IPriceService _priceService;
        private IPaymentService _paymentService;
        private IBalanceService _balanceService;
        private IDAL _dALService;
        private ISalesChannelFactory _SalesChannelFactoryService;


        public BookingService(IPriceService priceService, IPaymentService paymentService, IBalanceService balanceService, IDAL dALService, ISalesChannelFactory salesChannelFactoryService)
        {
            _priceService = priceService;
            _paymentService = paymentService;
            _balanceService = balanceService;
            _dALService = dALService;
            _SalesChannelFactoryService = salesChannelFactoryService;
        }

        public (bool, string) CreateBooking(string passengerName, string birthDate, string email, string salesChannel,
          DateTime bookingDate)
        {
            if (string.IsNullOrEmpty(passengerName))
            {
                return (false, string.Empty);
            }

            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                return (false, string.Empty);
            }

            if (string.IsNullOrEmpty(birthDate) || !DateTime.TryParse(birthDate, out var actualBirthDate))
            {
                return (false, string.Empty);
            }

            decimal price = _SalesChannelFactoryService.GetSalesChannel(salesChannel).GetPrice(bookingDate);


            //if (salesChannel == "website")
            //{

            //        price = _priceService.GetLowestPrice(bookingDate);
            //}
            //else
            //{

            //        price = _priceService.GetNormalPrice(bookingDate);
            //}



            var passengerId = _dALService.GetPassenger(email);
            if (passengerId == null)
            {
                passengerId = _dALService.AddPassenger(passengerName, actualBirthDate, email);
            }

            decimal userBalance = 0;
                userBalance = _balanceService.GetUserBalance(email);

            if (salesChannel == "website" && userBalance > 0 && userBalance >= price)
            {
                var bookingNumber = _dALService.CreateBooking(passengerId, bookingDate, price);
                return (true, bookingNumber);
            }
            else
            {
                var success = _paymentService.RequestPayment(email, price);
                if (success)
                {
                    var bookingNumber = _dALService.CreateBooking(passengerId, bookingDate, price);
                    return (true, bookingNumber);
                }
            }

            return (false, string.Empty);
        }
    }
}