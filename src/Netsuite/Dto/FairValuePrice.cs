namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class FairValuePrice : Record {

        private RecordRef customFormField;

        private RecordRef itemField;

        private RecordRef itemRevenueCategoryField;

        private double fairValueField;

        private bool fairValueFieldSpecified;

        private RecordRef fairValueFormulaField;

        private RecordRef currencyField;

        private RecordRef unitsTypeField;

        private RecordRef unitsField;

        private FairValuePriceFairValueRangePolicy fairValueRangePolicyField;

        private bool fairValueRangePolicyFieldSpecified;

        private double lowValueField;

        private bool lowValueFieldSpecified;

        private double lowValuePercentField;

        private bool lowValuePercentFieldSpecified;

        private double highValueField;

        private bool highValueFieldSpecified;

        private double highValuePercentField;

        private bool highValuePercentFieldSpecified;

        private bool isVsoePriceField;

        private bool isVsoePriceFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        private DimensionRef[] dimensionListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public RecordRef itemRevenueCategory {
            get {
                return this.itemRevenueCategoryField;
            }
            set {
                this.itemRevenueCategoryField = value;
            }
        }

        /// <remarks/>
        public double fairValue {
            get {
                return this.fairValueField;
            }
            set {
                this.fairValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fairValueSpecified {
            get {
                return this.fairValueFieldSpecified;
            }
            set {
                this.fairValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef fairValueFormula {
            get {
                return this.fairValueFormulaField;
            }
            set {
                this.fairValueFormulaField = value;
            }
        }

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
        public RecordRef unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        public FairValuePriceFairValueRangePolicy fairValueRangePolicy {
            get {
                return this.fairValueRangePolicyField;
            }
            set {
                this.fairValueRangePolicyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fairValueRangePolicySpecified {
            get {
                return this.fairValueRangePolicyFieldSpecified;
            }
            set {
                this.fairValueRangePolicyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double lowValue {
            get {
                return this.lowValueField;
            }
            set {
                this.lowValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lowValueSpecified {
            get {
                return this.lowValueFieldSpecified;
            }
            set {
                this.lowValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double lowValuePercent {
            get {
                return this.lowValuePercentField;
            }
            set {
                this.lowValuePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lowValuePercentSpecified {
            get {
                return this.lowValuePercentFieldSpecified;
            }
            set {
                this.lowValuePercentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double highValue {
            get {
                return this.highValueField;
            }
            set {
                this.highValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool highValueSpecified {
            get {
                return this.highValueFieldSpecified;
            }
            set {
                this.highValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double highValuePercent {
            get {
                return this.highValuePercentField;
            }
            set {
                this.highValuePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool highValuePercentSpecified {
            get {
                return this.highValuePercentFieldSpecified;
            }
            set {
                this.highValuePercentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isVsoePrice {
            get {
                return this.isVsoePriceField;
            }
            set {
                this.isVsoePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVsoePriceSpecified {
            get {
                return this.isVsoePriceFieldSpecified;
            }
            set {
                this.isVsoePriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("dimension", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public DimensionRef[] dimensionList {
            get {
                return this.dimensionListField;
            }
            set {
                this.dimensionListField = value;
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