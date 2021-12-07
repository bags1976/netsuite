namespace Netsuite.Enum
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:types.purchases_2021_1.transactions.webservices.netsuite.com")]
    public enum PurchaseOrderOrderStatus
    {
        /// Closed<remarks/>
        H,

        /// Fully Billed<remarks/>
        G,

        /// Partially Received<remarks/>
        D,

        /// Pending Billing Partially Received<remarks/>
        E,

        /// Pending Billing<remarks/>
        F,

        /// Pending Receipt<remarks/>
        B,

        /// Pending Supervisor Approval<remarks/>
        A,

        /// Rejected By Supervisor<remarks/>
        C,

        /// Not sure - but in docs<remarks/>
        P,

        ///  Not sure - but in docs<remarks/>
        Y
    }
}
