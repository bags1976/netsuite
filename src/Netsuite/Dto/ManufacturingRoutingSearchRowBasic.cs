namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ManufacturingRoutingSearchRowBasic : SearchRowBasic {

        private SearchColumnBooleanField[] autoCalculateLagField;

        private SearchColumnSelectField[] billOfMaterialsField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isDefaultField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnDoubleField[] lagAmountField;

        private SearchColumnEnumSelectField[] lagTypeField;

        private SearchColumnStringField[] lagUnitsField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnSelectField[] manufacturingCostTemplateField;

        private SearchColumnSelectField[] manufacturingWorkCenterField;

        private SearchColumnStringField[] memoField;

        private SearchColumnStringField[] nameField;

        private SearchColumnStringField[] operationNameField;

        private SearchColumnDoubleField[] operationYieldField;

        private SearchColumnDoubleField[] runRateField;

        private SearchColumnLongField[] sequenceField;

        private SearchColumnDoubleField[] setupTimeField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autoCalculateLag")]
        public SearchColumnBooleanField[] autoCalculateLag {
            get {
                return this.autoCalculateLagField;
            }
            set {
                this.autoCalculateLagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billOfMaterials")]
        public SearchColumnSelectField[] billOfMaterials {
            get {
                return this.billOfMaterialsField;
            }
            set {
                this.billOfMaterialsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isDefault")]
        public SearchColumnBooleanField[] isDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnBooleanField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("lagAmount")]
        public SearchColumnDoubleField[] lagAmount {
            get {
                return this.lagAmountField;
            }
            set {
                this.lagAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lagType")]
        public SearchColumnEnumSelectField[] lagType {
            get {
                return this.lagTypeField;
            }
            set {
                this.lagTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lagUnits")]
        public SearchColumnStringField[] lagUnits {
            get {
                return this.lagUnitsField;
            }
            set {
                this.lagUnitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturingCostTemplate")]
        public SearchColumnSelectField[] manufacturingCostTemplate {
            get {
                return this.manufacturingCostTemplateField;
            }
            set {
                this.manufacturingCostTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturingWorkCenter")]
        public SearchColumnSelectField[] manufacturingWorkCenter {
            get {
                return this.manufacturingWorkCenterField;
            }
            set {
                this.manufacturingWorkCenterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("operationName")]
        public SearchColumnStringField[] operationName {
            get {
                return this.operationNameField;
            }
            set {
                this.operationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("operationYield")]
        public SearchColumnDoubleField[] operationYield {
            get {
                return this.operationYieldField;
            }
            set {
                this.operationYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("runRate")]
        public SearchColumnDoubleField[] runRate {
            get {
                return this.runRateField;
            }
            set {
                this.runRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sequence")]
        public SearchColumnLongField[] sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setupTime")]
        public SearchColumnDoubleField[] setupTime {
            get {
                return this.setupTimeField;
            }
            set {
                this.setupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}