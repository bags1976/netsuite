namespace Netsuite.Dto
{
    public class VendorReturnAuthorization : TransactionQuery
    {
        public bool TaxRegOverride { get; set; }
        public bool TaxDetailsOverride { get; set; }
        public string OrderStatus { get; set; }
        public decimal? UserTotal { get; set; }
        public string CurrencyName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string EntityTaxRegNum { get; set; }
        public string TaxPointDate { get; set; }
        public decimal? UserTaxTotal { get; set; }
        public string Department { get; set; }
        public string Class { get; set; }
        public string Location { get; set; }
        public string IntercoTransaction { get; set; }
        public string IntercoStatus { get; set; }
    }
}
