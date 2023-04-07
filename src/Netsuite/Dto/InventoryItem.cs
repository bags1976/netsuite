namespace Netsuite.Dto
{
    public class InventoryItem : Item
    {
        public bool AvailableToPartners { get; set; }
        public bool EnforceMinQtyInternally { get; set; }
        public string FeaturedDescription { get; set; }
        public RecordRef StoreDisplayImage { get; set; }
        public string PageTitle { get; set; }
        public RecordRef PlanningItemCategory { get; set; }
        public int? SupplyTimeFence { get; set; }
        public int? LeadTime { get; set; }
        public string RelatedItemsDescription { get; set; }
        public int? RescheduleOutDays { get; set; }
        public bool RoundUpAsComponent { get; set; }
        public decimal? SafetyStockLevel { get; set; }
        public bool IsSerialItem { get; set; }
        public string StoreDescription { get; set; }
        public string StoreDisplayName { get; set; }
        public RecordRef UnBuildVarianceAccount { get; set; }
        public string UrlComponent { get; set; }
        public bool ParentOnly { get; set; }

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
}