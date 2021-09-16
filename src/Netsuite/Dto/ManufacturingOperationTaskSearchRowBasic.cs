namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ManufacturingOperationTaskSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] actualRunTimeField;

        private SearchColumnDoubleField[] actualSetupTimeField;

        private SearchColumnDoubleField[] completedQuantityField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnDoubleField[] estimatedWorkField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnLongField[] idField;

        private SearchColumnDoubleField[] inputQuantityField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnDoubleField[] laborResourcesField;

        private SearchColumnDoubleField[] lagAmountField;

        private SearchColumnEnumSelectField[] lagTypeField;

        private SearchColumnStringField[] lagUnitsField;

        private SearchColumnDoubleField[] machineResourcesField;

        private SearchColumnSelectField[] manufacturingCostTemplateField;

        private SearchColumnSelectField[] manufacturingWorkCenterField;

        private SearchColumnStringField[] messageField;

        private SearchColumnStringField[] nameField;

        private SearchColumnDoubleField[] orderField;

        private SearchColumnSelectField[] predecessorField;

        private SearchColumnStringField[] predecessorTypeField;

        private SearchColumnDoubleField[] remainingQuantityField;

        private SearchColumnDoubleField[] runRateField;

        private SearchColumnDoubleField[] runTimeField;

        private SearchColumnLongField[] sequenceField;

        private SearchColumnDoubleField[] setupTimeField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnSelectField[] statusField;

        private SearchColumnStringField[] workOrderField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualRunTime")]
        public SearchColumnDoubleField[] actualRunTime {
            get {
                return this.actualRunTimeField;
            }
            set {
                this.actualRunTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualSetupTime")]
        public SearchColumnDoubleField[] actualSetupTime {
            get {
                return this.actualSetupTimeField;
            }
            set {
                this.actualSetupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("completedQuantity")]
        public SearchColumnDoubleField[] completedQuantity {
            get {
                return this.completedQuantityField;
            }
            set {
                this.completedQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("estimatedWork")]
        public SearchColumnDoubleField[] estimatedWork {
            get {
                return this.estimatedWorkField;
            }
            set {
                this.estimatedWorkField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public SearchColumnLongField[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inputQuantity")]
        public SearchColumnDoubleField[] inputQuantity {
            get {
                return this.inputQuantityField;
            }
            set {
                this.inputQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("laborResources")]
        public SearchColumnDoubleField[] laborResources {
            get {
                return this.laborResourcesField;
            }
            set {
                this.laborResourcesField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("machineResources")]
        public SearchColumnDoubleField[] machineResources {
            get {
                return this.machineResourcesField;
            }
            set {
                this.machineResourcesField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public SearchColumnStringField[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("order")]
        public SearchColumnDoubleField[] order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("predecessor")]
        public SearchColumnSelectField[] predecessor {
            get {
                return this.predecessorField;
            }
            set {
                this.predecessorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("predecessorType")]
        public SearchColumnStringField[] predecessorType {
            get {
                return this.predecessorTypeField;
            }
            set {
                this.predecessorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("remainingQuantity")]
        public SearchColumnDoubleField[] remainingQuantity {
            get {
                return this.remainingQuantityField;
            }
            set {
                this.remainingQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("runTime")]
        public SearchColumnDoubleField[] runTime {
            get {
                return this.runTimeField;
            }
            set {
                this.runTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnSelectField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("workOrder")]
        public SearchColumnStringField[] workOrder {
            get {
                return this.workOrderField;
            }
            set {
                this.workOrderField = value;
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