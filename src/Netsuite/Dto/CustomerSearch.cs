using System;

namespace Netsuite.Dto
{
    public class CustomerSearch : Record
    {
        public string CompanyName { get; set; }
        public string Currency { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public bool IsInActive { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime? LastOrderDate { get; set; }
        public DateTime? LastSaleDate { get; set; }
        public bool OnCreditHold { get; set; }
        public string Phone { get; set; }
        public string ShippingCarrier { get; set; }
        public string BillToAddressId { get; set; }
        public string BillToAddressee { get; set; }
        public string BillToAddress1 { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToAddress3 { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToZip { get; set; }
        public string BillToCountry { get; set; }
        public string BillToAttention { get; set; }
        public string ShipToAddressId { get; set; }
        public string ShipToAddressee { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZip { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToAttention { get; set; }
    }
}
