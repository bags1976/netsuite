namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BillingRates {

        private RecordRef currencyField;

        private RecordRef billingClassField;

        private Rate[] rateListField;

        /// <remarks/>
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef billingClass {
            get {
                return this.billingClassField;
            }
            set {
                this.billingClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("rate", IsNullable=false)]
        public Rate[] rateList {
            get {
                return this.rateListField;
            }
            set {
                this.rateListField = value;
            }
        }
    }
}