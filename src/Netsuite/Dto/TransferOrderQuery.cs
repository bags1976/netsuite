using System;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [Serializable]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace =
        "urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class TransferOrderQuery : TransactionQuery
    {
        public string Currency { get; set; }

        public DateTime? ActualShipDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public DateTime? ActualReceiveDate { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public decimal? ExchangeRate { get; set; }

        public decimal? ForeignTotal { get; set; }

        public string LastModifiedBy { get; set; }

        public bool PaymentHold { get; set; }

        public string Email { get; set; }

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

        public TransactionLineQuery[] Item { get; set; }
    }
}