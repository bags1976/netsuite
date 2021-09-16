namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ManufacturingRoutingSearchBasic : SearchRecordBasic {

        private SearchBooleanField autoCalculateLagField;

        private SearchMultiSelectField billOfMaterialsField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isDefaultField;

        private SearchBooleanField isInactiveField;

        private SearchMultiSelectField itemField;

        private SearchDoubleField lagAmountField;

        private SearchEnumMultiSelectField lagTypeField;

        private SearchStringField lagUnitsField;

        private SearchMultiSelectField locationField;

        private SearchMultiSelectField manufacturingCostTemplateField;

        private SearchMultiSelectField manufacturingWorkCenterField;

        private SearchStringField memoField;

        private SearchStringField nameField;

        private SearchStringField operationNameField;

        private SearchDoubleField operationYieldField;

        private SearchDoubleField runRateField;

        private SearchLongField sequenceField;

        private SearchDoubleField setupTimeField;

        private SearchMultiSelectField subsidiaryField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchBooleanField autoCalculateLag {
            get {
                return this.autoCalculateLagField;
            }
            set {
                this.autoCalculateLagField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billOfMaterials {
            get {
                return this.billOfMaterialsField;
            }
            set {
                this.billOfMaterialsField = value;
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
        public SearchBooleanField isDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
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
        public SearchDoubleField lagAmount {
            get {
                return this.lagAmountField;
            }
            set {
                this.lagAmountField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField lagType {
            get {
                return this.lagTypeField;
            }
            set {
                this.lagTypeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField lagUnits {
            get {
                return this.lagUnitsField;
            }
            set {
                this.lagUnitsField = value;
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
        public SearchMultiSelectField manufacturingCostTemplate {
            get {
                return this.manufacturingCostTemplateField;
            }
            set {
                this.manufacturingCostTemplateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField manufacturingWorkCenter {
            get {
                return this.manufacturingWorkCenterField;
            }
            set {
                this.manufacturingWorkCenterField = value;
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
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchStringField operationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField operationYield {
            get {
                return this.operationYieldField;
            }
            set {
                this.operationYieldField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField runRate {
            get {
                return this.runRateField;
            }
            set {
                this.runRateField = value;
            }
        }

        /// <remarks/>
        public SearchLongField sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField setupTime {
            get {
                return this.setupTimeField;
            }
            set {
                this.setupTimeField = value;
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