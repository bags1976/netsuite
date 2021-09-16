namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ManufacturingOperationTaskSearchBasic : SearchRecordBasic {

        private SearchDoubleField actualRunTimeField;

        private SearchDoubleField actualSetupTimeField;

        private SearchDoubleField completedQuantityField;

        private SearchDateField endDateField;

        private SearchDoubleField estimatedWorkField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchLongField idField;

        private SearchDoubleField inputQuantityField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchDoubleField laborResourcesField;

        private SearchDoubleField lagAmountField;

        private SearchEnumMultiSelectField lagTypeField;

        private SearchStringField lagUnitsField;

        private SearchDoubleField machineResourcesField;

        private SearchMultiSelectField manufacturingCostTemplateField;

        private SearchMultiSelectField manufacturingWorkCenterField;

        private SearchStringField nameField;

        private SearchDoubleField orderField;

        private SearchMultiSelectField predecessorField;

        private SearchDoubleField remainingQuantityField;

        private SearchDoubleField runRateField;

        private SearchDoubleField runTimeField;

        private SearchLongField sequenceField;

        private SearchDoubleField setupTimeField;

        private SearchDateField startDateField;

        private SearchMultiSelectField statusField;

        private SearchMultiSelectField workOrderField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchDoubleField actualRunTime {
            get {
                return this.actualRunTimeField;
            }
            set {
                this.actualRunTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField actualSetupTime {
            get {
                return this.actualSetupTimeField;
            }
            set {
                this.actualSetupTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField completedQuantity {
            get {
                return this.completedQuantityField;
            }
            set {
                this.completedQuantityField = value;
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
        public SearchDoubleField estimatedWork {
            get {
                return this.estimatedWorkField;
            }
            set {
                this.estimatedWorkField = value;
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
        public SearchLongField id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField inputQuantity {
            get {
                return this.inputQuantityField;
            }
            set {
                this.inputQuantityField = value;
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
        public SearchDoubleField laborResources {
            get {
                return this.laborResourcesField;
            }
            set {
                this.laborResourcesField = value;
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
        public SearchDoubleField machineResources {
            get {
                return this.machineResourcesField;
            }
            set {
                this.machineResourcesField = value;
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
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField predecessor {
            get {
                return this.predecessorField;
            }
            set {
                this.predecessorField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField remainingQuantity {
            get {
                return this.remainingQuantityField;
            }
            set {
                this.remainingQuantityField = value;
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
        public SearchDoubleField runTime {
            get {
                return this.runTimeField;
            }
            set {
                this.runTimeField = value;
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
        public SearchDateField startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField workOrder {
            get {
                return this.workOrderField;
            }
            set {
                this.workOrderField = value;
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