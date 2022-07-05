using System;
using Netsuite.Dto;
using Netsuite.Enum;

public class InventoryItem
{
    public RecordRef AssetAccount { get; set; }
    public bool AvailableToPartners { get; set; }
    public decimal? AverageCost { get; set; }
    public long? BackwardConsumptionDays { get; set; }
    public bool Isfulfillable { get; set; }
    public RecordRef Class { get; set; }
    public RecordRef CostCategory { get; set; }
    public ItemCostEstimateType CostEstimateType { get; set; }
    public string CostingMethodDisplay { get; set; }
    public string CustReturnVarianceAccount { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string DeferralAccount { get; set; }
    public RecordRef DemandSource { get; set; }
    public long DemandTimeFence { get; set; }
    public RecordRef Department { get; set; }
    public string Description { get; set; }
    public string StoreDetailedDescription { get; set; }
    public string DisplayName { get; set; }
    public bool IsDropShipItem { get; set; }
    public RecordRef DropshipExpenseAccount { get; set; }
    public bool EnforceMinQtyInternally { get; set; }
    public decimal? DemandModifier { get; set; }
    public RecordRef BillExchRateVarianceAcct { get; set; }
    public RecordRef ExpenseAccount { get; set; }
    public string ExternalId { get; set; }
    public string FeaturedDescription { get; set; }
    public decimal? FixedLotSize { get; set; }
    public long ForwardConsumptionDays { get; set; }
    public string Fullname { get; set; }
    public RecordRef GainLossAccount { get; set; }
    public decimal? HandlingCost { get; set; }
    public bool IsInactive { get; set; }    
    public bool IncludeChildren { get; set; }
    public RecordRef IncomeAccount { get; set; }    
    public string Id { get; set; }
    public decimal? CostEstimate { get; set; }
    public RecordRef StoreDisplayImage { get; set; }
    public string ItemId { get; set; }
    public decimal? Weight { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public decimal? LastPurchasePrice { get; set; }
    public RecordRef Location { get; set; }
    public bool IsLotItem { get; set; }
    public string Manufacturer { get; set; }
    public string CountryOfManufacture { get; set; }
    public string Mpn { get; set; }
    public bool MatchBillToReceipt { get; set; }
    public long MaximumQuantity { get; set; }
    public long? MinimumQuantity { get; set; }    
    public string PageTitle { get; set; }
    public long PeriodicLotSizeDays { get; set; }
    public bool IsPhantom { get; set; }
    public RecordRef PlanningItemCategory { get; set; }
    public long SupplyTimeFence { get; set; }
    public RecordRef PreferredLocation { get; set; }
    public RecordRef BillPriceVarianceAcct { get; set; }
    public RecordRef PricingGroup { get; set; }
    public RecordRef ConsumptionUnit { get; set; }
    public RecordRef PurchaseUnit { get; set; }
    public RecordRef SaleUnit { get; set; }
    public RecordRef StockUnit { get; set; }
    public RecordRef UnitsType { get; set; }
    public RecordRef ProdPriceVarianceAcct { get; set; }
    public RecordRef ProdQtyVarianceAcct { get; set; }
    public string PurchaseDescription { get; set; }
    public long LeadTime { get; set; }
    public decimal? Cost { get; set; }
    public decimal? FxCost { get; set; }
    public RecordRef PurchasePriceVarianceAcct { get; set; }
    public RecordRef QuantityPricingSchedule { get; set; }
    public RecordRef BillQtyVarianceAcct { get; set; }
    public string RelatedItemsDescription { get; set; }
    public RecordRef SupplyReplenishmentMethod { get; set; }
    public long RescheduleInDays { get; set; }
    public long RescheduleOutDays { get; set; }
    public bool RoundUpAsComponent { get; set; }
    public decimal? SafetyStockLevel { get; set; }
    public RecordRef ScrapAcct { get; set; }
    public bool SeasonalDemand { get; set; }
    public bool IsSerialItem { get; set; }
    public decimal? ShippingCost { get; set; }
    public bool ShipIndividually { get; set; }
    public bool IsSpecialOrderItem { get; set; }
    public bool IsSpecialWorkOrderItem { get; set; }
    public string StockDescription { get; set; }
    public string StoreDescription { get; set; }
    public string StoreDisplayName { get; set; }
    public RecordRef Parent { get; set; }
    public string SubType { get; set; }
    public RecordRef SupplyType { get; set; }
    public decimal? TotalQuantityOnHand { get; set; }
    public decimal? TotalValue { get; set; }
    public bool TrackLandedCost { get; set; }
    public decimal? TransferPrice { get; set; }
    public ItemType ItemType { get; set; }
    public RecordRef UnBuildVarianceAccount { get; set; }
    public string UpcCode { get; set; }
    public string UrlComponent { get; set; }
    public bool ParentOnly { get; set; }
    public bool UseBins { get; set; }
    public bool UseMarginalRates { get; set; }
    public decimal? ReceiptAmount { get; set; }
    public decimal? ReceiptQuantityDiff { get; set; }
    public decimal? ReceiptQuantity { get; set; }
    public decimal? PurchaseOrderAmount { get; set; }
    public decimal? PurchaseOrderQuantityDiff { get; set; }
    public decimal? PurchaseOrderQuantity { get; set; }
    public string VendorName { get; set; }
    public RecordRef VendReturnVarianceAccount { get; set; }
    public int WeightUnit { get; set; }
    public string WeightUnits { get; set; }
    public RecordRef WipAcct { get; set; }
    public RecordRef WipVarianceAcct { get; set; }
    public string Subsidiary { get; set; }
    

    // other fields that may exist on object, yet do not exist in the item query
    // public string SalesDescription { get; set; }
    // public RecordRef IntercoIncomeAccount { get; set; }
    // public RecordRef TaxSchedule { get; set; }
    // public bool IsTaxable { get; set; }
    // public string ShippingCostUnits { get; set; }
    // public bool Producer { get; set; }
    // public string ManufacturerAddr1 { get; set; }
    // public string ManufacturerCity { get; set; }
    // public string ManufacturerState { get; set; }
    // public string ManufacturerZip { get; set; }
    // public RecordRef DefaultItemShipMethod { get; set; }
    // public string ItemCarrier { get; set; }
    // public string ManufacturerTaxId { get; set; }
    // public string ScheduleBNumber { get; set; }
    // public long? ScheduleBQuantity { get; set; }
    // public string ScheduleBCode { get; set; }
    // public string ManufacturerTariff { get; set; }
    // public string PreferenceCriterion { get; set; }
    // public string MinimumQuantityUnits { get; set; }
    // public RecordRef SoftDescriptor { get; set; }
    // public bool PricesIncludeTax { get; set; }
    // public string ReorderPointUnits { get; set; }
    // public string PreferredStockLevelUnits { get; set; }
    // public ItemOverallQuantityPricingType OverallQuantityPricingType { get; set; }
    // public string CostEstimateUnits { get; set; }
    // public RecordRef ItemRevenueCategory { get; set; }
    // public bool IsStorePickupAllowed { get; set; }
    // public long ReorderMultiple { get; set; }
    // public DateTime? LastInvtCountDate { get; set; }
    // public DateTime? NextInvtCountDate { get; set; }
    // public long InvtCountInterval { get; set; }
    // public string CostUnits { get; set; }
    // public string QuantityReorderUnits { get; set; }
    // public bool AutoLeadTime { get; set; }
    // public bool AutoPreferredStockLevel { get; set; }
    // public decimal? PreferredStockLevelDays { get; set; }
    // public long SafetyStockLevelDays { get; set; }
    // public string SafetyStockLevelUnits { get; set; }
    // public RecordRef DistributionNetwork { get; set; }
    // public RecordRef DistributionCategory { get; set; }
    // public bool AutoReorderPoint { get; set; }
    // public RecordRef StoreItemTemplate { get; set; }
    // public bool IsDonationItem { get; set; }
    // public bool ShowDefaultDonationAmount { get; set; }
    // public decimal? MaxDonationAmount { get; set; }
    // public bool DontShowPrice { get; set; }
    // public string NoPriceMessage { get; set; }
    // public string OutOfStockMessage { get; set; }
    // public bool OnSpecial { get; set; }
    // public ItemOutOfStockBehavior OutOfStockBehavior { get; set; }
    // public string SpecialsDescription { get; set; }
    // public RecordRef CustomForm { get; set; }
    // public bool IsHazmatItem { get; set; }
    // public string HazmatId { get; set; }
    // public string HazmatShippingName { get; set; }
    // public string HazmatHazardClass { get; set; }
    // public string HazmatPackingGroup { get; set; }
    // public string HazmatItemUnits { get; set; }
    // public decimal? HazmatItemUnitsQty { get; set; }
    // public bool IsGcoCompliant { get; set; }
    // public bool OfferSupport { get; set; }
    // public ItemCostingMethod CostingMethod { get; set; }
    // public string Currency { get; set; }
    // public decimal? PreferredStockLevel { get; set; }
    // public RecordRef PurchaseTaxCode { get; set; }
    // public decimal? DefaultReturnCost { get; set; }
    // public decimal? QuantityBackOrdered { get; set; }
    // public decimal? QuantityCommitted { get; set; }
    // public decimal? QuantityAvailable { get; set; }
    // public decimal? QuantityOnHand { get; set; }
    // public decimal? OnHandValueMli { get; set; }
    // public decimal? QuantityOnOrder { get; set; }
    // public decimal? Rate { get; set; }
    // public decimal? ReorderPoint { get; set; }
    // public string QuantityCommittedUnits { get; set; }
    // public RecordRef SalesTaxCode { get; set; }
    // public string QuantityAvailableUnits { get; set; }
    // public string QuantityOnHandUnits { get; set; }
    // public RecordRef Vendor { get; set; }
    // public string QuantityOnOrderUnits { get; set; }
    // public long FutureHorizon { get; set; }
    // public bool EnableCatchWeight { get; set; }
    // public RecordRef SecondaryUnitsType { get; set; }
    // public RecordRef SecondaryBaseUnit { get; set; }
    // public decimal? ConversionRate { get; set; }
    // public RecordRef SecondaryStockUnit { get; set; }
    // public RecordRef SecondarySaleUnit { get; set; }
    // public RecordRef SecondaryPurchaseUnit { get; set; }
    // public RecordRef SecondaryConsumptionUnit { get; set; }
    // public decimal? LowerWarningLimit { get; set; }
    // public decimal? UpperWarningLimit { get; set; }
}
