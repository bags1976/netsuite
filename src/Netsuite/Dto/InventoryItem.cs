using System;
using Netsuite.Dto;
using Netsuite.Enum;

public class InventoryItem
{
    public DateTime? CreatedDate { get; set; }

    public DateTime LastModifiedDate { get; set; }

    public string PurchaseDescription { get; set; }

    public RecordRef ExpenseAccount { get; set; }

    public DateTime DateConvertedToInv { get; set; }

    public ItemType OriginalItemType { get; set; }

    public ItemSubType OriginalItemSubtype { get; set; }

    public RecordRef CogsAccount { get; set; }

    public RecordRef IntercoCogsAccount { get; set; }

    public string SalesDescription { get; set; }

    public bool? IncludeChildren { get; set; }

    public RecordRef IncomeAccount { get; set; }

    public RecordRef IntercoIncomeAccount { get; set; }

    public RecordRef TaxSchedule { get; set; }

    public RecordRef DropshipExpenseAccount { get; set; }

    public RecordRef RevenueRecognitionRule { get; set; }

    public RecordRef RevRecForecastRule { get; set; }

    public RecordRef RevenueAllocationGroup { get; set; }

    public RecordRef CreateRevenuePlansOn { get; set; }

    public bool? DirectRevenuePosting { get; set; }

    public bool? ContingentRevenueHandling { get; set; }

    public RecordRef RevReclassFxAccount { get; set; }

    public bool? IsTaxable { get; set; }

    public RecordRef AssetAccount { get; set; }

    public bool? MatchBillToReceipt { get; set; }

    public RecordRef BillQtyVarianceAcct { get; set; }

    public RecordRef BillPriceVarianceAcct { get; set; }

    public RecordRef BillExchRateVarianceAcct { get; set; }

    public RecordRef GainLossAccount { get; set; }

    public decimal? ShippingCost { get; set; }

    public string ShippingCostUnits { get; set; }

    public decimal? HandlingCost { get; set; }

    public string HandlingCostUnits { get; set; }

    public decimal? Weight { get; set; }

    public string WeightUnits { get; set; }

    public string CostingMethodDisplay { get; set; }

    public RecordRef UnitsType { get; set; }

    public RecordRef StockUnit { get; set; }

    public RecordRef PurchaseUnit { get; set; }

    public RecordRef SaleUnit { get; set; }

    public RecordRef IssueProduct { get; set; }

    public RecordRef BillingSchedule { get; set; }

    public bool? TrackLandedCost { get; set; }

    public string MatrixItemNameTemplate { get; set; }

    public bool? IsDropShipItem { get; set; }

    public bool? IsSpecialOrderItem { get; set; }

    public string StockDescription { get; set; }

    public RecordRef DeferredRevenueAccount { get; set; }

    public RecordRef IntercoDefRevAccount { get; set; }

    public bool? Producer { get; set; }

    public string Manufacturer { get; set; }

    public RecordRef RevRecSchedule { get; set; }

    public string Mpn { get; set; }

    public bool? MultManufactureAddr { get; set; }

    public string ManufacturerAddr1 { get; set; }

    public string ManufacturerCity { get; set; }

    public string ManufacturerState { get; set; }

    public string ManufacturerZip { get; set; }

    public string CountryOfManufacture { get; set; }

    public bool? RoundUpAsComponent { get; set; }

    public decimal? PurchaseOrderQuantity { get; set; }

    public decimal? PurchaseOrderAmount { get; set; }

    public decimal? PurchaseOrderQuantityDiff { get; set; }

    public decimal? ReceiptQuantity { get; set; }

    public decimal? ReceiptAmount { get; set; }

    public decimal? ReceiptQuantityDiff { get; set; }

    public RecordRef DefaultItemShipMethod { get; set; }

    public string ItemCarrier { get; set; }

    public string ManufacturerTaxId { get; set; }

    public string ScheduleBNumber { get; set; }

    public long? ScheduleBQuantity { get; set; }

    public string ScheduleBCode { get; set; }

    public string ManufacturerTariff { get; set; }

    public string PreferenceCriterion { get; set; }

    public long? MinimumQuantity { get; set; }

    public bool? EnforceMinQtyInternally { get; set; }

    public long MaximumQuantity { get; set; }

    public string MinimumQuantityUnits { get; set; }

    public RecordRef SoftDescriptor { get; set; }

    public RecordRef ShipPackage { get; set; }

    public bool? ShipIndividually { get; set; }

    public RecordRef CostCategory { get; set; }

    public bool? PricesIncludeTax { get; set; }

    public RecordRef PurchasePriceVarianceAcct { get; set; }

    public RecordRef QuantityPricingSchedule { get; set; }

    public string ReorderPointUnits { get; set; }

    public bool? UseMarginalRates { get; set; }

    public string PreferredStockLevelUnits { get; set; }

    public ItemCostEstimateType CostEstimateType { get; set; }

    public decimal? CostEstimate { get; set; }

    public decimal? TransferPrice { get; set; }

    public ItemOverallQuantityPricingType OverallQuantityPricingType { get; set; }

    public RecordRef PricingGroup { get; set; }

    public string CostEstimateUnits { get; set; }

    public RecordRef ItemRevenueCategory { get; set; }

    public RecordRef PreferredLocation { get; set; }

    public bool? IsStorePickupAllowed { get; set; }

    public long ReorderMultiple { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? LastInvtCountDate { get; set; }

    public DateTime? NextInvtCountDate { get; set; }

    public long InvtCountInterval { get; set; }

    public string CostUnits { get; set; }

    public decimal? TotalValue { get; set; }

    public decimal? AverageCost { get; set; }

    public bool? UseBins { get; set; }

    public string QuantityReorderUnits { get; set; }

    public long LeadTime { get; set; }

    public bool? AutoLeadTime { get; set; }

    public decimal? LastPurchasePrice { get; set; }

    public bool? AutoPreferredStockLevel { get; set; }

    public decimal? PreferredStockLevelDays { get; set; }

    public decimal? SafetyStockLevel { get; set; }

    public long SafetyStockLevelDays { get; set; }

    public long BackwardConsumptionDays { get; set; }

    public bool? SeasonalDemand { get; set; }

    public string SafetyStockLevelUnits { get; set; }

    public decimal? DemandModifier { get; set; }

    public RecordRef DistributionNetwork { get; set; }

    public RecordRef DistributionCategory { get; set; }

    public bool? AutoReorderPoint { get; set; }

    public string StoreDisplayName { get; set; }

    public RecordRef StoreDisplayThumbnail { get; set; }

    public RecordRef StoreDisplayImage { get; set; }

    public string StoreDescription { get; set; }

    public string StoreDetailedDescription { get; set; }

    public RecordRef StoreItemTemplate { get; set; }

    public string PageTitle { get; set; }

    public string MetaTagHtml { get; set; }

    public bool? ExcludeFromSitemap { get; set; }

    public bool? IsDonationItem { get; set; }

    public bool? ShowDefaultDonationAmount { get; set; }

    public decimal? MaxDonationAmount { get; set; }

    public bool? DontShowPrice { get; set; }

    public string NoPriceMessage { get; set; }

    public string OutOfStockMessage { get; set; }

    public bool? OnSpecial { get; set; }

    public ItemOutOfStockBehavior OutOfStockBehavior { get; set; }

    public string RelatedItemsDescription { get; set; }

    public string SpecialsDescription { get; set; }

    public string FeaturedDescription { get; set; }

    public string NexTagCategory { get; set; }

    public string UrlComponent { get; set; }

    public RecordRef CustomForm { get; set; }

    public string ItemId { get; set; }

    public string Id { get; set; }

    public string UpcCode { get; set; }

    public string Description { get; set; }

    public string Fullname { get; set; }

    public string VendorName { get; set; }

    public bool? IsOnline { get; set; }

    public bool? IsHazmatItem { get; set; }

    public string HazmatId { get; set; }

    public string HazmatShippingName { get; set; }

    public string HazmatHazardClass { get; set; }

    public string HazmatPackingGroup { get; set; }

    public string HazmatItemUnits { get; set; }

    public decimal? HazmatItemUnitsQty { get; set; }

    public bool? IsGcoCompliant { get; set; }

    public bool? OfferSupport { get; set; }

    public bool? IsInactive { get; set; }

    public bool? IsLotItem { get; set; }

    public bool? AvailableToPartners { get; set; }

    public RecordRef Department { get; set; }

    public RecordRef Class { get; set; }

    public RecordRef Location { get; set; }

    public ItemCostingMethod CostingMethod { get; set; }

    public string Currency { get; set; }

    public decimal? PreferredStockLevel { get; set; }

    public RecordRef PurchaseTaxCode { get; set; }

    public decimal? DefaultReturnCost { get; set; }

    public RecordRef SupplyReplenishmentMethod { get; set; }

    public RecordRef AlternateDemandSourceItem { get; set; }

    public decimal? FixedLotSize { get; set; }

    public RecordRef SupplyType { get; set; }

    public long DemandTimeFence { get; set; }

    public long SupplyTimeFence { get; set; }

    public long RescheduleInDays { get; set; }

    public long RescheduleOutDays { get; set; }

    public long PeriodicLotSizeDays { get; set; }

    public RecordRef SupplyLotSizingMethod { get; set; }

    public long ForwardConsumptionDays { get; set; }

    public RecordRef DemandSource { get; set; }

    public decimal? QuantityBackOrdered { get; set; }

    public decimal? QuantityCommitted { get; set; }

    public decimal? QuantityAvailable { get; set; }

    public decimal? QuantityOnHand { get; set; }

    public decimal? OnHandValueMli { get; set; }

    public decimal? QuantityOnOrder { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ReorderPoint { get; set; }

    public string QuantityCommittedUnits { get; set; }

    public RecordRef SalesTaxCode { get; set; }

    public string QuantityAvailableUnits { get; set; }

    public string QuantityOnHandUnits { get; set; }

    public RecordRef Vendor { get; set; }

    public string QuantityOnOrderUnits { get; set; }

    public string Subsidiary { get; set; }

    public long FutureHorizon { get; set; }

    public RecordRef ConsumptionUnit { get; set; }

    public bool? EnableCatchWeight { get; set; }

    public RecordRef SecondaryUnitsType { get; set; }

    public RecordRef SecondaryBaseUnit { get; set; }

    public decimal? ConversionRate { get; set; }

    public RecordRef SecondaryStockUnit { get; set; }

    public RecordRef SecondarySaleUnit { get; set; }

    public RecordRef SecondaryPurchaseUnit { get; set; }

    public RecordRef SecondaryConsumptionUnit { get; set; }

    public decimal? LowerWarningLimit { get; set; }

    public decimal? UpperWarningLimit { get; set; }

    public RecordRef PlanningItemCategory { get; set; }

    public string InternalId { get; set; }

    public string ExternalId { get; set; }
}
