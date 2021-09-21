using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Currency : Record {

        private string nameField;

        private string symbolField;

        private bool isBaseCurrencyField;

        private bool isBaseCurrencyFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool overrideCurrencyFormatField;

        private bool overrideCurrencyFormatFieldSpecified;

        private string displaySymbolField;

        private CurrencySymbolPlacement symbolPlacementField;

        private bool symbolPlacementFieldSpecified;

        private CurrencyLocale localeField;

        private bool localeFieldSpecified;

        private string formatSampleField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private CurrencyFxRateUpdateTimezone fxRateUpdateTimezoneField;

        private bool fxRateUpdateTimezoneFieldSpecified;

        private bool inclInFxRateUpdatesField;

        private bool inclInFxRateUpdatesFieldSpecified;

        private CurrencyCurrencyPrecision currencyPrecisionField;

        private bool currencyPrecisionFieldSpecified;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string symbol {
            get {
                return this.symbolField;
            }
            set {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        public bool isBaseCurrency {
            get {
                return this.isBaseCurrencyField;
            }
            set {
                this.isBaseCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBaseCurrencySpecified {
            get {
                return this.isBaseCurrencyFieldSpecified;
            }
            set {
                this.isBaseCurrencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool overrideCurrencyFormat {
            get {
                return this.overrideCurrencyFormatField;
            }
            set {
                this.overrideCurrencyFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideCurrencyFormatSpecified {
            get {
                return this.overrideCurrencyFormatFieldSpecified;
            }
            set {
                this.overrideCurrencyFormatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string displaySymbol {
            get {
                return this.displaySymbolField;
            }
            set {
                this.displaySymbolField = value;
            }
        }

        /// <remarks/>
        public CurrencySymbolPlacement symbolPlacement {
            get {
                return this.symbolPlacementField;
            }
            set {
                this.symbolPlacementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool symbolPlacementSpecified {
            get {
                return this.symbolPlacementFieldSpecified;
            }
            set {
                this.symbolPlacementFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CurrencyLocale locale {
            get {
                return this.localeField;
            }
            set {
                this.localeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool localeSpecified {
            get {
                return this.localeFieldSpecified;
            }
            set {
                this.localeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string formatSample {
            get {
                return this.formatSampleField;
            }
            set {
                this.formatSampleField = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exchangeRateSpecified {
            get {
                return this.exchangeRateFieldSpecified;
            }
            set {
                this.exchangeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CurrencyFxRateUpdateTimezone fxRateUpdateTimezone {
            get {
                return this.fxRateUpdateTimezoneField;
            }
            set {
                this.fxRateUpdateTimezoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fxRateUpdateTimezoneSpecified {
            get {
                return this.fxRateUpdateTimezoneFieldSpecified;
            }
            set {
                this.fxRateUpdateTimezoneFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool inclInFxRateUpdates {
            get {
                return this.inclInFxRateUpdatesField;
            }
            set {
                this.inclInFxRateUpdatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inclInFxRateUpdatesSpecified {
            get {
                return this.inclInFxRateUpdatesFieldSpecified;
            }
            set {
                this.inclInFxRateUpdatesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CurrencyCurrencyPrecision currencyPrecision {
            get {
                return this.currencyPrecisionField;
            }
            set {
                this.currencyPrecisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currencyPrecisionSpecified {
            get {
                return this.currencyPrecisionFieldSpecified;
            }
            set {
                this.currencyPrecisionFieldSpecified = value;
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