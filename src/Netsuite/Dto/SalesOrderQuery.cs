using System;
using System.Collections.Generic;

namespace Netsuite.Dto
{
    public class SalesOrderQuery : Record
    {
        public string Entity { get; set; }
        public string Currency { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ActualShipDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? ForeignTotal { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? TranDate { get; set; }
        public string Number { get; set; }
        public string TranId { get; set; }
        public string TransactionNumber { get; set; }
        public bool PaymentHold { get; set; }
        public bool Posting { get; set; }
        public bool PostingPeriod { get; set; }
        public bool Voided { get; set; }
        public string Status { get; set; }
        public string Memo { get; set; }
        public string Email { get; set; }
        public string BillAddressAttention { get; set; }
        public string BillAddressLine1 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressState { get; set; }
        public string BillAddressZip { get; set; }
        public string BillAddressCountry { get; set; }
        public string BillAddressPhone { get; set; }
        public string ShipAddressAttention { get; set; }
        public string ShipAddressLine1 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressState { get; set; }
        public string ShipAddressZip { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressPhone { get; set; }
        public string CustBody_DN_SO_CustomField1 { get; set; }
        public string CustBody_DN_SO_CustomField2 { get; set; }
        public string CustBody_DN_SO_CustomField3 { get; set; }
        public string CustBody_DN_SO_CustomField4 { get; set; }
        public string CustBody_DN_SO_CustomField5 { get; set; }
        public string CustBody_DN_SO_CustomField6 { get; set; }
        public string CustBody_DN_SO_CustomField7 { get; set; }
        public string CustBody_DN_SO_CustomField8 { get; set; }
        public string CustBody_DN_SO_CustomField9 { get; set; }
        public string CustBody_DN_SO_CustomField10 { get; set; }
        public List<SalesOrderLineQuery> Item { get; set; }
    }
}
