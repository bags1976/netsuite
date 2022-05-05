using System;
using Netsuite.Enum;

namespace Netsuite.Dto
{
    public partial class SalesOrderItem
    {
        public bool HasFulfillableItems { get; set; }
        public bool TaxLine { get; set; }
        public bool BinItem { get; set; }
        public bool LocationUsesBins { get; set; }
        public bool IsPosting { get; set; }
        public bool ItemPicked { get; set; }
        public bool IsSerial { get; set; }
        public bool IsOpen { get; set; }
        public bool Fulfillable { get; set; }
        public bool ItemPacked { get; set; }
        public decimal OnOrder { get; set; }
        public decimal OrigQuantity { get; set; }
        public decimal UnitConversionRate { get; set; }
        public string WeightInLb { get; set; }
        public string Subsidiary { get; set; }
        public string Units { get; set; }
        public string Units_Display { get; set; }
        public string Item_Display { get; set; }
        public string Id { get; set; }
        public RecordRef Job { get; set; }
        public RecordRef Subscription { get; set; }
        public RecordRef Item { get; set; }
        public decimal QuantityAvailable { get; set; }
        public bool ExpandItemGroup { get; set; }
        public long? LineUniqueKey { get; set; }
        public decimal QuantityOnHand { get; set; }
        public decimal Quantity { get; set; }
        public InventoryDetail InventoryDetail { get; set; }
        public string Description { get; set; }
        public RecordRef Price { get; set; }
        public decimal Rate { get; set; }
        public string SerialNumbers { get; set; }
        public decimal Amount { get; set; }
        public bool IsTaxable { get; set; }
        public SalesOrderItemCommitInventory CommitInventory { get; set; }
        public decimal? OrderPriority { get; set; }
        public string LicenseCode { get; set; }
        public RecordRef Department { get; set; }
        public RecordRef Class { get; set; }
        public RecordRef Location { get; set; }
        public SalesOrderItemCreatePo CreatePo { get; set; }
        public RecordRef CreatedPo { get; set; }
        public decimal? AltSalesAmt { get; set; }
        public bool CreateWo { get; set; }
        public RecordRef PoVendor { get; set; }
        public string PoCurrency { get; set; }
        public decimal PoRate { get; set; }
        public RecordRef RevRecSchedule { get; set; }
        public DateTime RevRecStartDate { get; set; }
        public long? RevRecTermInMonths { get; set; }
        public DateTime? RevRecEndDate { get; set; }
        public bool DeferRevRec { get; set; }
        public bool IsClosed { get; set; }
        public SalesOrderItemFulfillmentChoice ItemFulfillmentChoice { get; set; }
        public RecordRef CatchUpPeriod { get; set; }
        public RecordRef BillingSchedule { get; set; }
        public bool FromJob { get; set; }
        public decimal GrossAmt { get; set; }
        public decimal TaxAmount { get; set; }
        public bool ExcludeFromRateRequest { get; set; }
        public bool IsEstimate { get; set; }
        public RecordRef InventoryLocation { get; set; }
        public RecordRef InventorySubsidiary { get; set; }
        public int Line { get; set; }
        public decimal? PercentComplete { get; set; }
        public ItemCostEstimateType CostEstimateType { get; set; }
        public decimal CostEstimate { get; set; }
        public decimal QuantityBackOrdered { get; set; }
        public decimal QuantityBilled{ get; set; }
        public decimal QuantityCommitted{ get; set; }
        public decimal QuantityFulfilled{ get; set; }
        public decimal QuantityPacked{ get; set; }
        public decimal QuantityPicked{ get; set; }
        public decimal Tax1Amt{ get; set; }
        public RecordRef TaxCode{ get; set; }
        public decimal TaxRate1{ get; set; }
        public decimal TaxRate2{ get; set; }
        public string GiftCertFrom{ get; set; }
        public string GiftCertRecipientName{ get; set; }
        public string GiftCertRecipientEmail{ get; set; }
        public string GiftCertMessage{ get; set; }
        public string GiftCertNumber{ get; set; }
        public long ShipGroup{ get; set; }
        public bool ItemIsFulfilled{ get; set; }
        public RecordRef ShipAddress{ get; set; }
        public RecordRef ShipMethod{ get; set; }
        public bool VsoeIsEstimate{ get; set; }
        public decimal VsoePrice{ get; set; }
        public decimal VsoeAmount{ get; set; }
        public decimal VsoeAllocation{ get; set; }
        public bool VsoeDelivered{ get; set; }
        public DateTime? ExpectedShipDate { get; set; }
        public bool NoAutoAssignLocation{ get; set; }
        public bool LocationAutoAssigned{ get; set; }
        public string TaxDetailsReference{ get; set; }
        public RecordRef ChargeType{ get; set; }
        public RecordRef OrderAllocationStrategy{ get; set; }
        public DateTime? RequestedDate { get; set; }
    }
}
