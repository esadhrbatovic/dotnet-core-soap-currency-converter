using System.Runtime.Serialization;

namespace CurrencyConverter
{
    [DataContract]
    public class CurrencyConversionRequest
    {
        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public string? FromCurrency { get; set; }

        [DataMember]
        public string? ToCurrency { get; set; }
    }
}
