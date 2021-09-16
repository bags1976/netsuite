namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ConsolidatedExchangeRate : Record {

        private string postingPeriodField;

        private string fromSubsidiaryField;

        private string fromCurrencyField;

        private string toSubsidiaryField;

        private string toCurrencyField;

        private double averageRateField;

        private bool averageRateFieldSpecified;

        private double currentRateField;

        private bool currentRateFieldSpecified;

        private double historicalRateField;

        private bool historicalRateFieldSpecified;

        private string accountingBookField;

        private bool isPeriodClosedField;

        private bool isPeriodClosedFieldSpecified;

        private bool isDerivedField;

        private bool isDerivedFieldSpecified;

        private bool isEliminationSubsidiaryField;

        private bool isEliminationSubsidiaryFieldSpecified;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

        /// <remarks/>
        public string fromSubsidiary {
            get {
                return this.fromSubsidiaryField;
            }
            set {
                this.fromSubsidiaryField = value;
            }
        }

        /// <remarks/>
        public string fromCurrency {
            get {
                return this.fromCurrencyField;
            }
            set {
                this.fromCurrencyField = value;
            }
        }

        /// <remarks/>
        public string toSubsidiary {
            get {
                return this.toSubsidiaryField;
            }
            set {
                this.toSubsidiaryField = value;
            }
        }

        /// <remarks/>
        public string toCurrency {
            get {
                return this.toCurrencyField;
            }
            set {
                this.toCurrencyField = value;
            }
        }

        /// <remarks/>
        public double averageRate {
            get {
                return this.averageRateField;
            }
            set {
                this.averageRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool averageRateSpecified {
            get {
                return this.averageRateFieldSpecified;
            }
            set {
                this.averageRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double currentRate {
            get {
                return this.currentRateField;
            }
            set {
                this.currentRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentRateSpecified {
            get {
                return this.currentRateFieldSpecified;
            }
            set {
                this.currentRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double historicalRate {
            get {
                return this.historicalRateField;
            }
            set {
                this.historicalRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool historicalRateSpecified {
            get {
                return this.historicalRateFieldSpecified;
            }
            set {
                this.historicalRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        public bool isPeriodClosed {
            get {
                return this.isPeriodClosedField;
            }
            set {
                this.isPeriodClosedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPeriodClosedSpecified {
            get {
                return this.isPeriodClosedFieldSpecified;
            }
            set {
                this.isPeriodClosedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isDerived {
            get {
                return this.isDerivedField;
            }
            set {
                this.isDerivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDerivedSpecified {
            get {
                return this.isDerivedFieldSpecified;
            }
            set {
                this.isDerivedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isEliminationSubsidiary {
            get {
                return this.isEliminationSubsidiaryField;
            }
            set {
                this.isEliminationSubsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEliminationSubsidiarySpecified {
            get {
                return this.isEliminationSubsidiaryFieldSpecified;
            }
            set {
                this.isEliminationSubsidiaryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}