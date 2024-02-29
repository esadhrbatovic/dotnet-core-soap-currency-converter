using System.ServiceModel;

namespace CurrencyConverter
{
    [ServiceContract]
    public interface ICurrencyConverterService
    {
        [OperationContract]
        CurrencyConversionResult ConvertCurrency(CurrencyConversionRequest req);

    }

    public class CurrencyConverterService : ICurrencyConverterService { 
    

        public double GetRandomDoubleBetween(double min, double max)
        {
            Random random = new Random();
            double amount = random.NextDouble() * (max - min) + min;

            return Math.Round(amount, 2);
        }

        public CurrencyConversionResult ConvertCurrency(CurrencyConversionRequest req)
        {

            CurrencyConversionResult res = new CurrencyConversionResult
            {
                Amount = GetRandomDoubleBetween(10, 1000),
                Currency = "USD"
            };

            return res;
            
        }
    }

}
