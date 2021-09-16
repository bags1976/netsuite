namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class FairValuePriceSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField currencyField;

        private SearchDateField endDateField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchDoubleField fairValueField;

        private SearchMultiSelectField fairValueFormulaField;

        private SearchEnumMultiSelectField fairValueRangePolicyField;

        private SearchDoubleField highValueField;

        private SearchDoubleField highValuePercentField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isVsoePriceField;

        private SearchMultiSelectField itemField;

        private SearchMultiSelectField itemRevenueCategoryField;

        private SearchDoubleField lowValueField;

        private SearchDoubleField lowValuePercentField;

        private SearchDateField startDateField;

        private SearchMultiSelectField unitsTypeField;

        /// <remarks/>
        public SearchMultiSelectField currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public SearchDateField endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fairValue {
            get {
                return this.fairValueField;
            }
            set {
                this.fairValueField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField fairValueFormula {
            get {
                return this.fairValueFormulaField;
            }
            set {
                this.fairValueFormulaField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField fairValueRangePolicy {
            get {
                return this.fairValueRangePolicyField;
            }
            set {
                this.fairValueRangePolicyField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField highValue {
            get {
                return this.highValueField;
            }
            set {
                this.highValueField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField highValuePercent {
            get {
                return this.highValuePercentField;
            }
            set {
                this.highValuePercentField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isVsoePrice {
            get {
                return this.isVsoePriceField;
            }
            set {
                this.isVsoePriceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField itemRevenueCategory {
            get {
                return this.itemRevenueCategoryField;
            }
            set {
                this.itemRevenueCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField lowValue {
            get {
                return this.lowValueField;
            }
            set {
                this.lowValueField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField lowValuePercent {
            get {
                return this.lowValuePercentField;
            }
            set {
                this.lowValuePercentField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }
    }
}