namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class CurrencyRateFilter {

        private RecordRef baseCurrencyField;

        private RecordRef fromCurrencyField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        /// <remarks/>
        public RecordRef baseCurrency {
            get {
                return this.baseCurrencyField;
            }
            set {
                this.baseCurrencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef fromCurrency {
            get {
                return this.fromCurrencyField;
            }
            set {
                this.fromCurrencyField = value;
            }
        }

        /// <remarks/>
        public System.DateTime effectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveDateSpecified {
            get {
                return this.effectiveDateFieldSpecified;
            }
            set {
                this.effectiveDateFieldSpecified = value;
            }
        }
    }
}