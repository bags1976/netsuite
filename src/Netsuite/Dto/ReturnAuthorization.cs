using System;

namespace Netsuite.Dto
{
    public class ReturnAuthorization : TransactionQuery
    {
        public bool TaxRegOverride { get; set; }
        public string VatRegNum { get; set; }
        public string EntityTaxRegNum { get; set; }
        public DateTime TaxPointDate { get; set; }
        public string Source { get; set; }
        public string Department { get; set; }
        public string Class { get; set; }
        public string Location { get; set; }
        public string IntercoTransaction { get; set; }
        public string IntercoStatus { get; set; }
        public string Job { get; set; }
        public string Partner { get; set; }
        public string LeadSource { get; set; }
        public string DrAccount { get; set; }
        public string FxAccount { get; set; }
        public DateTime SalesEffectiveDate { get; set; }
        public string RevRecSchedule { get; set; }
        public decimal? TotalCostEstimate { get; set; }
        public decimal? EstGrossProfit { get; set; }
        public decimal? EstGrossProfitPercent { get; set; }
        public DateTime RevRecStartDate { get; set; }
        public DateTime RevRecEndDate { get; set; }
        public bool ExcludeCommission { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string CurrencyName { get; set; }
        public string DiscountItem { get; set; }
        public string DiscountRate { get; set; }
        public string TaxItem { get; set; }
        public decimal? TaxRate { get; set; }
        public bool ToBePrinted { get; set; }
        public bool ToBeEmailed { get; set; }
        public bool ToBeFaxed { get; set; }
        public string MessageSel { get; set; }
        public string Message { get; set; }
        public string ShipAddress { get; set; }
        public string SalesGroup { get; set; }
        public bool SyncSalesTeams { get; set; }
        public string RevenueStatus { get; set; }
        public decimal? RecognizedRevenue { get; set; }
        public decimal? DeferredRevenue { get; set; }
        public bool RevRecOnRevCommitment { get; set; }
        public string RevCommitStatus { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? AltSalesTotal { get; set; }
        public string PnRefNum { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? DiscountTotal { get; set; }
        public decimal? Total { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public bool IsTaxable { get; set; }
        public string PromoCode { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? Tax2Total { get; set; }
        public DateTime ValidFrom { get; set; }
        public string OrderStatus { get; set; }
        public string SalesRep { get; set; }
        public string GiftCert { get; set; }
        public string ContribPct { get; set; }
        public decimal? GiftCertTotal { get; set; }
        public decimal? GiftCertApplied { get; set; }
        public decimal? GiftCertAvailable { get; set; }
        public bool TranIsVsoeBundle { get; set; }
        public bool VsoeAutoCalc { get; set; }
        public bool SyncPartnerTeams { get; set; }
    }
}
