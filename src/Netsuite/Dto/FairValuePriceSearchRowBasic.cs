namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class FairValuePriceSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] currencyField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnDoubleField[] fairValueField;

        private SearchColumnSelectField[] fairValueFormulaField;

        private SearchColumnEnumSelectField[] fairValueRangePolicyField;

        private SearchColumnDoubleField[] highValueField;

        private SearchColumnDoubleField[] highValuePercentField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isVsoePriceField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnSelectField[] itemRevenueCategoryField;

        private SearchColumnDoubleField[] lowValueField;

        private SearchColumnDoubleField[] lowValuePercentField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnSelectField[] unitsField;

        private SearchColumnSelectField[] unitsTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency")]
        public SearchColumnSelectField[] currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endDate")]
        public SearchColumnDateField[] endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("fairValue")]
        public SearchColumnDoubleField[] fairValue {
            get {
                return this.fairValueField;
            }
            set {
                this.fairValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fairValueFormula")]
        public SearchColumnSelectField[] fairValueFormula {
            get {
                return this.fairValueFormulaField;
            }
            set {
                this.fairValueFormulaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fairValueRangePolicy")]
        public SearchColumnEnumSelectField[] fairValueRangePolicy {
            get {
                return this.fairValueRangePolicyField;
            }
            set {
                this.fairValueRangePolicyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("highValue")]
        public SearchColumnDoubleField[] highValue {
            get {
                return this.highValueField;
            }
            set {
                this.highValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("highValuePercent")]
        public SearchColumnDoubleField[] highValuePercent {
            get {
                return this.highValuePercentField;
            }
            set {
                this.highValuePercentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isVsoePrice")]
        public SearchColumnBooleanField[] isVsoePrice {
            get {
                return this.isVsoePriceField;
            }
            set {
                this.isVsoePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnSelectField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemRevenueCategory")]
        public SearchColumnSelectField[] itemRevenueCategory {
            get {
                return this.itemRevenueCategoryField;
            }
            set {
                this.itemRevenueCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lowValue")]
        public SearchColumnDoubleField[] lowValue {
            get {
                return this.lowValueField;
            }
            set {
                this.lowValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lowValuePercent")]
        public SearchColumnDoubleField[] lowValuePercent {
            get {
                return this.lowValuePercentField;
            }
            set {
                this.lowValuePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDate")]
        public SearchColumnDateField[] startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("units")]
        public SearchColumnSelectField[] units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitsType")]
        public SearchColumnSelectField[] unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }
    }
}