namespace Netsuite.Dto
{
    public abstract class AddressQuery : Record
    {
        public string BillAddressee { get; set; }
        public string BillingAddress { get; set; }
        public string BillAddressAttention { get; set; }
        public string BillAddressLine1 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressState { get; set; }
        public string BillAddressZip { get; set; }
        public string BillAddressCountry { get; set; }
        public string BillAddressPhone { get; set; }
        public string ShipAddressee { get; set; }
        public string ShippingAddress { get; set; }
        public string ShipAddressAttention { get; set; }
        public string ShipAddressLine1 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressState { get; set; }
        public string ShipAddressZip { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressPhone { get; set; }
    }
}
