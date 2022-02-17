using ConsoleApp1.Interfaces;
using System;


namespace ConsoleApp1
{
    public class WebsiteSalesChannel : ISalesChannel
    {
        private readonly IPriceService _priceService;

        public WebsiteSalesChannel(IPriceService priceService)
        {
            _priceService = priceService;
        }

        public decimal GetPrice(DateTime bookingDate)
        {
          return  _priceService.GetLowestPrice(bookingDate);
        }
    }
}
