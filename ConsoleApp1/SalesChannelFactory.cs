using ConsoleApp1.Interfaces;


namespace ConsoleApp1
{
    public class SalesChannelFactory : ISalesChannelFactory
    {
        private readonly IPriceService _priceService;

        public SalesChannelFactory(IPriceService priceService)
        {
            _priceService = priceService;
        }

        public ISalesChannel GetSalesChannel(string salesChannel)
        {
            switch (salesChannel)
            {
                case "website":
                    return new WebsiteSalesChannel(_priceService);

                default:
                    return new OtherSalesChannel(_priceService);
            }
        }
    }
}
