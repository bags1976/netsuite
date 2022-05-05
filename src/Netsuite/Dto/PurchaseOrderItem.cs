using Netsuite.Enum;
using System;

namespace Netsuite.Dto
{
    public partial class PurchaseOrderItem
    {
        public string Subsidiary { get; set; }
        public bool Fulfillable { get; set; }
        public string Id { get; set; }
        public RecordRef Item { get; set; }
        public long Line { get; set; }
        public decimal QuantityOnShipments { get; set; }
        public string VendorName { get; set; }
        public decimal QuantityReceived { get; set; }
        public decimal QuantityBilled { get; set; }
        public decimal QuantityAvailable { get; set; }
        public decimal QuantityOnHand { get; set; }
        public RecordRef TaxCode { get; set; }
        public decimal TaxRate1 { get; set; }
        public decimal TaxRate2 { get; set; }
        public decimal Quantity { get; set; }
        public decimal Tax1Amt { get; set; }
        public decimal GrossAmt { get; set; }
        public RecordRef Units { get; set; }
        public InventoryDetail InventoryDetail { get; set; }
        public string SerialNumbers { get; set; }
        public string Description { get; set; }
        public RecordRef PurchaseContract { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal TaxAmount { get; set; }
        public RecordRef Department { get; set; }
        public RecordRef Class { get; set; }
        public RecordRef Location { get; set; }
        public RecordRef LandedCostCategory { get; set; }
        public RecordRef Customer { get; set; }
        public bool? IsBillable { get; set; }
        public TransactionBillVarianceStatus BillVarianceStatus { get; set; }
        public bool? MatchBillToReceipt { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public bool IsClosed { get; set; }
        public string TaxDetailsReference { get; set; }
        public RecordRef CreatedFrom { get; set; }
    }
}
