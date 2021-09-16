namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class PaymentInstrumentSearchRow : SearchRow {

        private PaymentInstrumentSearchRowBasic basicField;

        private CustomerSearchRowBasic customerJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        /// <remarks/>
        public PaymentInstrumentSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchRowBasic customerJoin {
            get {
                return this.customerJoinField;
            }
            set {
                this.customerJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic transactionJoin {
            get {
                return this.transactionJoinField;
            }
            set {
                this.transactionJoinField = value;
            }
        }
    }
}