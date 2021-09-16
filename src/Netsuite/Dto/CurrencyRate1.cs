namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CurrencyRate", Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class CurrencyRate1 {

        private RecordRef baseCurrencyField;

        private RecordRef fromCurrencyField;

        private double exchangeRateField;

        private System.DateTime effectiveDateField;

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
        public double exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
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
    }
}