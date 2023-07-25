using System;

namespace Netsuite.Dto
{
    public class InboundShipmentItem : Record
    {
        public string PurchaseOrderTransaction { get; set; }
        public string ShipmentItem { get; set; }
        public string ShipmentItemDescription { get; set; }
        public string VendorId { get; set; }
        public string ReceivingLocation { get; set; }
        public decimal? QuantityReceived { get; set; }
        public decimal? QuantityExpected { get; set; }
        public decimal? QuantityRemaining { get; set; }
        public string Unit { get; set; }
        public decimal? PoRate { get; set; }
        public decimal? ExpectedRate { get; set; }
        public decimal? ShipmentItemExchangeRate { get; set; }
        public DateTime? ShipmentItemEffectiveDate { get; set; }
        public decimal? UnitLandedCost { get; set; }
        public decimal? TotalUnitCost { get; set; }
        public decimal? ShipmentItemAmount { get; set; }
        public string PoCurrency { get; set; }
        public string Incoterm { get; set; }
    }
}
