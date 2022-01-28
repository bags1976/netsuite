using System;
using System.Collections.Generic;

namespace Netsuite.Dto
{
    public class PurchaseOrderQuery : AddressQuery
    {
        public string TranId { get; set; }
        public string Memo { get; set; }
        public string Subsidiary { get; set; }
        public string Entity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool Void { get; set; }
        public string OtherRefNum { get; set; }
        public string CustBody_DN_PO_CustomField1 { get; set; }
        public string CustBody_DN_PO_CustomField2 { get; set; }
        public string CustBody_DN_PO_CustomField3 { get; set; }
        public string CustBody_DN_PO_CustomField4 { get; set; }
        public string CustBody_DN_PO_CustomField5 { get; set; }
        public string CustBody_DN_PO_CustomField6 { get; set; }
        public string CustBody_DN_PO_CustomField7 { get; set; }
        public string CustBody_DN_PO_CustomField8 { get; set; }
        public string CustBody_DN_PO_CustomField9 { get; set; }
        public string CustBody_DN_PO_CustomField10 { get; set; }
        public List<PurchaseOrderLineQuery> Item { get; set; }
    }
}
