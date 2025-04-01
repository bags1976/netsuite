using System;
using System.Collections.Generic;

namespace Netsuite.Dto
{
    public class TransactionLineQuery : Record
    {
        public string PartNumber { get; set; }
        public string UniqueKey { get; set; }
        public bool IsBillable { get; set; }
        public bool IsClosed { get; set; }
        public string ExpenseAccount { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public DateTime? ExpectedShipDate { get; set; }
        public DateTime? ActualShipDate { get; set; }
        public bool Fulfillable { get; set; }
        public bool AssemblyComponent { get; set; }
        public bool KitComponent { get; set; }
        public string Entity { get; set; }
        public bool IsCogs { get; set; }
        public string Memo { get; set; }
        public string Description { get; set; }
        public string Item { get; set; }
        public string ItemType { get; set; }
        public string ItemSource { get; set; }
        public decimal Quantity { get; set; }
        public string Subsidiary { get; set; }
        public string TargetSubsidiary { get; set; }
        public string DueToFromSubsidiary { get; set; }
        public string Transaction { get; set; }
        public decimal NetAmount { get; set; }
        public decimal? Price { get; set; }
        public string Units { get; set; }
        public decimal? OrderPriority { get; set; }
        public decimal? QuantityPicked { get; set; }
        public decimal? QuantityRejected { get; set; }
        public decimal? QuantityBilled { get; set; }
        public decimal? QuantityPacked { get; set; }
        public decimal? QuantityShipRecv { get; set; }
        public decimal? QuantityBackOrdered { get; set; }
        public decimal? QuantityCommitted { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public bool HasFulfillableItems { get; set; }
        public string CommitInventory { get; set; }
        public bool CommitmentFirm { get; set; }
        public string CreatedFrom { get; set; }
        public decimal? Rate { get; set; }
        public decimal? RateAmount { get; set; }
        public decimal? ForeignAmount { get; set; }
        public bool IsFullyShipped { get; set; }
        public bool TaxLine { get; set; }
        public bool SpecialOrder { get; set; }
        public string Location { get; set; }
        public bool MainLine { get; set; }
        public int LineSequenceNumber { get; set; }
        public string TransactionLineType { get; set; }
        public string TransferOrderItemLineId { get; set; }
        public List<InventoryAssignmentQuery> InventoryAssignment { get; set; }
        public virtual Dictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }
}
