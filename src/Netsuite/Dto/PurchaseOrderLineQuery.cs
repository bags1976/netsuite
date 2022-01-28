using System;

namespace Netsuite.Dto
{
    public class PurchaseOrderLineQuery : Record
    {
        public bool AssemblyComponent { get; set; }
        public bool DropShip { get; set; }
        public bool Fulfillable { get; set; }
        public bool CommitInventory { get; set; }
        public bool IsBillable { get; set; }
        public bool IsClosed { get; set; }
        public bool IsCogs { get; set; }
        public bool KitComponent { get; set; }
        public string Item { get; set; }
        public string ItemId { get; set; }
        public string Description { get; set; }
        public string Entity { get; set; }
        public string ExpenseAccount { get; set; }
        public DateTime? ExpectedShipDate { get; set; }
        public DateTime? ActualShipDate { get; set; }
        public decimal ForeignAmount { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityBackOrdered { get; set; }
        public decimal QuantityBilled { get; set; }
        public decimal QuantityPacked { get; set; }
        public decimal QuantityPicked { get; set; }
        public decimal QuantityRejected { get; set; }
        public decimal QuantityShippRecv { get; set; }
        public decimal Rate { get; set; }
        public decimal RateAmount { get; set; }
        public bool SpecialOrder { get; set; }
        public string Subsidiary { get; set; }
        public bool TaxLine { get; set; }
        public string Transaction { get; set; }
        public string Units { get; set; }
        public bool IsFullyShipped { get; set; }
        public string Location { get; set; }
        public decimal NetAmount { get; set; }
    }
}
