namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ItemDemandPlanSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField alternateSourceItemField;

        private SearchLongField analysisDurationField;

        private SearchDateField demandDateField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField itemField;

        private SearchDateField lastModifiedDateField;

        private SearchMultiSelectField locationField;

        private SearchStringField memoField;

        private SearchLongField projectionDurationField;

        private SearchMultiSelectField projectionIntervalField;

        private SearchEnumMultiSelectField projectionMethodField;

        private SearchDateField projectionStartDateField;

        private SearchDoubleField quantityField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField unitsField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField alternateSourceItem {
            get {
                return this.alternateSourceItemField;
            }
            set {
                this.alternateSourceItemField = value;
            }
        }

        /// <remarks/>
        public SearchLongField analysisDuration {
            get {
                return this.analysisDurationField;
            }
            set {
                this.analysisDurationField = value;
            }
        }

        /// <remarks/>
        public SearchDateField demandDate {
            get {
                return this.demandDateField;
            }
            set {
                this.demandDateField = value;
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
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public SearchStringField memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public SearchLongField projectionDuration {
            get {
                return this.projectionDurationField;
            }
            set {
                this.projectionDurationField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField projectionInterval {
            get {
                return this.projectionIntervalField;
            }
            set {
                this.projectionIntervalField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField projectionMethod {
            get {
                return this.projectionMethodField;
            }
            set {
                this.projectionMethodField = value;
            }
        }

        /// <remarks/>
        public SearchDateField projectionStartDate {
            get {
                return this.projectionStartDateField;
            }
            set {
                this.projectionStartDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}