namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CurrencyRateSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] baseCurrencyField;

        private SearchColumnDateField[] effectiveDateField;

        private SearchColumnDoubleField[] exchangeRateField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] transactionCurrencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("baseCurrency")]
        public SearchColumnSelectField[] baseCurrency {
            get {
                return this.baseCurrencyField;
            }
            set {
                this.baseCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("effectiveDate")]
        public SearchColumnDateField[] effectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("exchangeRate")]
        public SearchColumnDoubleField[] exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transactionCurrency")]
        public SearchColumnSelectField[] transactionCurrency {
            get {
                return this.transactionCurrencyField;
            }
            set {
                this.transactionCurrencyField = value;
            }
        }
    }
}