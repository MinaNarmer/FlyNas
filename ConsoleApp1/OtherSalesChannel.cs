using ConsoleApp1.Interfaces;
using System;


namespace ConsoleApp1
{
    public class OtherSalesChannel : ISalesChannel
    {
        private readonly IPriceService _priceService;

        public OtherSalesChannel(IPriceService priceService)
        {
            _priceService = priceService;
        }

        public decimal GetPrice(DateTime bookingDate)
        {
            return _priceService.GetNormalPrice(bookingDate);
        }
    }
}
