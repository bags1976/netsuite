namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class PromotionCodeCurrency {

        private RecordRef currencyField;

        private double minimumOrderAmountField;

        private bool minimumOrderAmountFieldSpecified;

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
        public double minimumOrderAmount {
            get {
                return this.minimumOrderAmountField;
            }
            set {
                this.minimumOrderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumOrderAmountSpecified {
            get {
                return this.minimumOrderAmountFieldSpecified;
            }
            set {
                this.minimumOrderAmountFieldSpecified = value;
            }
        }
    }
}