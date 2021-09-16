namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ConsolidatedExchangeRateSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] accountingBookField;

        private SearchColumnStringField[] averageRateField;

        private SearchColumnBooleanField[] closedField;

        private SearchColumnStringField[] currentRateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] fromCurrencyField;

        private SearchColumnStringField[] fromSubsidiaryField;

        private SearchColumnStringField[] historicalRateField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnDateField[] periodEndDateField;

        private SearchColumnStringField[] periodNameField;

        private SearchColumnDateField[] periodStartDateField;

        private SearchColumnStringField[] toCurrencyField;

        private SearchColumnStringField[] toSubsidiaryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBook")]
        public SearchColumnStringField[] accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("averageRate")]
        public SearchColumnStringField[] averageRate {
            get {
                return this.averageRateField;
            }
            set {
                this.averageRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("closed")]
        public SearchColumnBooleanField[] closed {
            get {
                return this.closedField;
            }
            set {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currentRate")]
        public SearchColumnStringField[] currentRate {
            get {
                return this.currentRateField;
            }
            set {
                this.currentRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fromCurrency")]
        public SearchColumnStringField[] fromCurrency {
            get {
                return this.fromCurrencyField;
            }
            set {
                this.fromCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fromSubsidiary")]
        public SearchColumnStringField[] fromSubsidiary {
            get {
                return this.fromSubsidiaryField;
            }
            set {
                this.fromSubsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("historicalRate")]
        public SearchColumnStringField[] historicalRate {
            get {
                return this.historicalRateField;
            }
            set {
                this.historicalRateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("periodEndDate")]
        public SearchColumnDateField[] periodEndDate {
            get {
                return this.periodEndDateField;
            }
            set {
                this.periodEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("periodName")]
        public SearchColumnStringField[] periodName {
            get {
                return this.periodNameField;
            }
            set {
                this.periodNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("periodStartDate")]
        public SearchColumnDateField[] periodStartDate {
            get {
                return this.periodStartDateField;
            }
            set {
                this.periodStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("toCurrency")]
        public SearchColumnStringField[] toCurrency {
            get {
                return this.toCurrencyField;
            }
            set {
                this.toCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("toSubsidiary")]
        public SearchColumnStringField[] toSubsidiary {
            get {
                return this.toSubsidiaryField;
            }
            set {
                this.toSubsidiaryField = value;
            }
        }
    }
}