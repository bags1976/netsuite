using System;

namespace Netsuite.Dto
{
    public class TransactionQuery : AddressQuery
    {
        public string InterCoTransaction { get; set; }
        public string InterCoStatus { get; set; }
        public bool InterCoAdj { get; set; }
        public string Entity { get; set; }
        public string TranId { get; set; }
        public string TransactionNumber { get; set; }
        public string TranDisplayName { get; set; }
        public string ShipCarrier { get; set; }
        public int Number { get; set; }
        public DateTime? TranDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string CreatedBy { get; set; }
        public string Memo { get; set; }
        public string Status { get; set; }
        public string ToSubsidiary { get; set; }
        public bool Voided { get; set; }
        public bool Void { get; set; }
        public bool Posting { get; set; }
        public bool PaymentHold { get; set; }
        public bool ShipComplete { get; set; }
        public string PostingPeriod { get; set; }
        public string OtherRefNum { get; set; }
        public string RecordType { get; set; }
    }
}
