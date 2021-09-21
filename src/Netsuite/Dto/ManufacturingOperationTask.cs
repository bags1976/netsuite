using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingOperationTask : Record {

        private RecordRef customFormField;

        private RecordRef manufacturingWorkCenterField;

        private RecordRef manufacturingCostTemplateField;

        private string titleField;

        private long operationSequenceField;

        private bool operationSequenceFieldSpecified;

        private RecordRef workOrderField;

        private RecordRef orderField;

        private ManufacturingOperationTaskStatus statusField;

        private bool statusFieldSpecified;

        private string messageField;

        private double estimatedWorkField;

        private bool estimatedWorkFieldSpecified;

        private double actualWorkField;

        private bool actualWorkFieldSpecified;

        private double remainingWorkField;

        private bool remainingWorkFieldSpecified;

        private double inputQuantityField;

        private bool inputQuantityFieldSpecified;

        private double completedQuantityField;

        private bool completedQuantityFieldSpecified;

        private double setupTimeField;

        private bool setupTimeFieldSpecified;

        private double runRateField;

        private bool runRateFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private bool autoCalculateLagField;

        private bool autoCalculateLagFieldSpecified;

        private double machineResourcesField;

        private bool machineResourcesFieldSpecified;

        private double laborResourcesField;

        private bool laborResourcesFieldSpecified;

        private ManufacturingCostDetailList costDetailListField;

        private ManufacturingOperationTaskPredecessorList predecessorListField;

        private CustomFieldRef[] customFieldListField;

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
        public RecordRef manufacturingWorkCenter {
            get {
                return this.manufacturingWorkCenterField;
            }
            set {
                this.manufacturingWorkCenterField = value;
            }
        }

        /// <remarks/>
        public RecordRef manufacturingCostTemplate {
            get {
                return this.manufacturingCostTemplateField;
            }
            set {
                this.manufacturingCostTemplateField = value;
            }
        }

        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public long operationSequence {
            get {
                return this.operationSequenceField;
            }
            set {
                this.operationSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationSequenceSpecified {
            get {
                return this.operationSequenceFieldSpecified;
            }
            set {
                this.operationSequenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef workOrder {
            get {
                return this.workOrderField;
            }
            set {
                this.workOrderField = value;
            }
        }

        /// <remarks/>
        public RecordRef order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }

        /// <remarks/>
        public ManufacturingOperationTaskStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public double estimatedWork {
            get {
                return this.estimatedWorkField;
            }
            set {
                this.estimatedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedWorkSpecified {
            get {
                return this.estimatedWorkFieldSpecified;
            }
            set {
                this.estimatedWorkFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double actualWork {
            get {
                return this.actualWorkField;
            }
            set {
                this.actualWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actualWorkSpecified {
            get {
                return this.actualWorkFieldSpecified;
            }
            set {
                this.actualWorkFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double remainingWork {
            get {
                return this.remainingWorkField;
            }
            set {
                this.remainingWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool remainingWorkSpecified {
            get {
                return this.remainingWorkFieldSpecified;
            }
            set {
                this.remainingWorkFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double inputQuantity {
            get {
                return this.inputQuantityField;
            }
            set {
                this.inputQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inputQuantitySpecified {
            get {
                return this.inputQuantityFieldSpecified;
            }
            set {
                this.inputQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double completedQuantity {
            get {
                return this.completedQuantityField;
            }
            set {
                this.completedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completedQuantitySpecified {
            get {
                return this.completedQuantityFieldSpecified;
            }
            set {
                this.completedQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double setupTime {
            get {
                return this.setupTimeField;
            }
            set {
                this.setupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool setupTimeSpecified {
            get {
                return this.setupTimeFieldSpecified;
            }
            set {
                this.setupTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double runRate {
            get {
                return this.runRateField;
            }
            set {
                this.runRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool runRateSpecified {
            get {
                return this.runRateFieldSpecified;
            }
            set {
                this.runRateFieldSpecified = value;
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
        public bool autoCalculateLag {
            get {
                return this.autoCalculateLagField;
            }
            set {
                this.autoCalculateLagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoCalculateLagSpecified {
            get {
                return this.autoCalculateLagFieldSpecified;
            }
            set {
                this.autoCalculateLagFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double machineResources {
            get {
                return this.machineResourcesField;
            }
            set {
                this.machineResourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool machineResourcesSpecified {
            get {
                return this.machineResourcesFieldSpecified;
            }
            set {
                this.machineResourcesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double laborResources {
            get {
                return this.laborResourcesField;
            }
            set {
                this.laborResourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool laborResourcesSpecified {
            get {
                return this.laborResourcesFieldSpecified;
            }
            set {
                this.laborResourcesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ManufacturingCostDetailList costDetailList {
            get {
                return this.costDetailListField;
            }
            set {
                this.costDetailListField = value;
            }
        }

        /// <remarks/>
        public ManufacturingOperationTaskPredecessorList predecessorList {
            get {
                return this.predecessorListField;
            }
            set {
                this.predecessorListField = value;
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