using System;
using Netsuite.Enum;

namespace Netsuite.Dto
{
    public class Item : Record
    {
        public string ProdQtyVarianceAcct { get; set; }
        public string PurchaseUnit { get; set; }
        public long RescheduleInDays { get; set; }
        public decimal? AverageCost { get; set; }
        public bool ShipIndividually { get; set; }
        public string CreateExpensePlansOn { get; set; }
        public string Periodiclotsizetype { get; set; }
        public decimal? CostEstimate { get; set; }
        public string CountryOfManufacture { get; set; }
        public bool IsSpecialOrderItem { get; set; }
        public string DropShipExpenseAccount { get; set; }
        public string StockUnit { get; set; }
        public string SaleUnit { get; set; }
        public string ExpenseAccount { get; set; }
        public string PurchasePriceVarianceAcct { get; set; }
        public bool IsFulfillable { get; set; }
        public string GenerateAccruals { get; set; }
        public string ExpenseAmortizationRule { get; set; }
        public string Description { get; set; }
        public string ItemId { get; set; }
        public string Class { get; set; }
        public string InterCoexpenseAccount { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public string SubType { get; set; }
        public string BillQtyVarianceAcct { get; set; }
        public bool IsPhantom { get; set; }
        public string ReScheduleOutDays { get; set; }
        public string CustReturnVarianceAccount { get; set; }
        public bool SeasonalDemand { get; set; }
        public string ConsumptionUnit { get; set; }
        public bool UseBins { get; set; }
        public string CostEstimateType { get; set; }
        public decimal? Weight { get; set; }
        public string RotationType { get; set; }
        public decimal? HandlingCost { get; set; }
        public string DeferralAccount { get; set; }
        public string AlternateDemandSourceItem { get; set; }
        public string DemandSource { get; set; }
        public string DisplayName { get; set; }
        public string VendReturnVarianceAccount { get; set; }
        public bool IsSpecialWorkOrderItem { get; set; }
        public string Parent { get; set; }
        public string SupplyType { get; set; }
        public string QuantityPricingSchedule { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal? FxCost { get; set; }
        public string BillExchRateVarianceAcct { get; set; }
        public long PeriodicLotSizeDays { get; set; }
        public string SupplyReplenishmentMethod { get; set; }
        public string Manufacturer { get; set; }
        public string IsOnline { get; set; }
        public long DemandTimeFence { get; set; }
        public string UnbuildVarianceAccount { get; set; }
        public string OverallQuantityPricingType { get; set; }
        public decimal? DemandModifier { get; set; }
        public string StockDescription { get; set; }
        public string PrintItems { get; set; }
        public bool TrackLandedCost { get; set; }
        public string WipVarianceAcct { get; set; }
        public string GainLossAccount { get; set; }
        public string PricingGroup { get; set; }
        public string PreferredLocation { get; set; }
        public string ItemProcessFamily { get; set; }
        public long ForwardConsumptionDays { get; set; }
        public string SupplyLotSizingMethod { get; set; }
        public string IsDropShipItem { get; set; }
        public string BillPriceVarianceAcct { get; set; }
        public string WipAcct { get; set; }
        public bool MatchBillToReceipt { get; set; }
        public string Location { get; set; }
        public string VendorName { get; set; }
        public string ShipPackage { get; set; }
        public string ProdPriceVarianceAcct { get; set; }
        public string IncomeAccount { get; set; }
        public string Residual { get; set; }
        public string AtpMethod { get; set; }
        public long? MinimumQuantity { get; set; }
        public string ScrapAcct { get; set; }
        public decimal? TransferPrice { get; set; }
        public string AssetAccount { get; set; }
        public string UnitsType { get; set; }
        public decimal? Cost { get; set; }
        public string CostingMethod { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public long? BackwardConsumptionDays { get; set; }
        public string UpcCode { get; set; }
        public bool IsLotItem { get; set; }
        public bool IncludeChildren { get; set; }
        public string Subsidiary { get; set; }
        public ItemType ItemType { get; set; }
        public string FullName { get; set; }
        public string BuildEntireAssembly { get; set; }
        public bool UseMarginalRates { get; set; }
        public decimal? ShippingCost { get; set; }
        public string RoundupAsComponent { get; set; }
        public string AmortizationTemplate { get; set; }
        public bool IsInactive { get; set; }
        public string PurchaseDescription { get; set; }
        public string IntercoIncomeAccount { get; set; }
        public decimal? FixedLotSize { get; set; }
        public string CostingMethodDisplay { get; set; }
        public string ItemProcessGroup { get; set; }
        public string ExternalId { get; set; }
        public long MaximumQuantity { get; set; }
        public string AmortizationPeriod { get; set; }
        public decimal? TotalQuantityOnHand { get; set; }
        public decimal? TotalValue { get; set; }
        public string Department { get; set; }
        public string Mpn { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public decimal? ReceiptQuantityDiff { get; set; }
        public decimal? ReceiptQuantity { get; set; }
        public decimal? PurchaseOrderAmount { get; set; }
        public decimal? PurchaseOrderQuantityDiff { get; set; }
        public decimal? PurchaseOrderQuantity { get; set; }
        public string WeightUnit { get; set; }
    }
}
