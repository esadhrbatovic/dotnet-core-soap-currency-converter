using System.Runtime.Serialization;

namespace CurrencyConverter
{
    [DataContract]
    public class CurrencyConversionResult
    {
        [DataMember]
        public string? Currency { get; set; }

        [DataMember]
        public double Amount { get; set; }
    }
}
