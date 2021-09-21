using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class WorkOrderItem {

        private long lineField;

        private bool lineFieldSpecified;

        private RecordRef itemField;

        private long operationSequenceNumberField;

        private bool operationSequenceNumberFieldSpecified;

        private double componentYieldField;

        private bool componentYieldFieldSpecified;

        private double bomQuantityField;

        private bool bomQuantityFieldSpecified;

        private double quantityCommittedField;

        private bool quantityCommittedFieldSpecified;

        private double quantityBackOrderedField;

        private bool quantityBackOrderedFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private double averageCostField;

        private bool averageCostFieldSpecified;

        private double lastPurchasePriceField;

        private bool lastPurchasePriceFieldSpecified;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private RecordRef unitsField;

        private InventoryDetail inventoryDetailField;

        private string serialNumbersField;

        private double orderPriorityField;

        private bool orderPriorityFieldSpecified;

        private CustomFieldRef[] optionsField;

        private ItemSource itemSourceField;

        private bool itemSourceFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef poVendorField;

        private double poRateField;

        private bool poRateFieldSpecified;

        private double percentCompleteField;

        private bool percentCompleteFieldSpecified;

        private double contributionField;

        private bool contributionFieldSpecified;

        private string descriptionField;

        private WorkOrderItemItemCommitInventory commitInventoryField;

        private bool commitInventoryFieldSpecified;

        private System.DateTime plannedIssueDateField;

        private bool plannedIssueDateFieldSpecified;

        private RecordRef orderAllocationStrategyField;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public long line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineSpecified {
            get {
                return this.lineFieldSpecified;
            }
            set {
                this.lineFieldSpecified = value;
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
        public long operationSequenceNumber {
            get {
                return this.operationSequenceNumberField;
            }
            set {
                this.operationSequenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationSequenceNumberSpecified {
            get {
                return this.operationSequenceNumberFieldSpecified;
            }
            set {
                this.operationSequenceNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double componentYield {
            get {
                return this.componentYieldField;
            }
            set {
                this.componentYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool componentYieldSpecified {
            get {
                return this.componentYieldFieldSpecified;
            }
            set {
                this.componentYieldFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double bomQuantity {
            get {
                return this.bomQuantityField;
            }
            set {
                this.bomQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bomQuantitySpecified {
            get {
                return this.bomQuantityFieldSpecified;
            }
            set {
                this.bomQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityCommitted {
            get {
                return this.quantityCommittedField;
            }
            set {
                this.quantityCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityCommittedSpecified {
            get {
                return this.quantityCommittedFieldSpecified;
            }
            set {
                this.quantityCommittedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityBackOrdered {
            get {
                return this.quantityBackOrderedField;
            }
            set {
                this.quantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityBackOrderedSpecified {
            get {
                return this.quantityBackOrderedFieldSpecified;
            }
            set {
                this.quantityBackOrderedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityAvailableSpecified {
            get {
                return this.quantityAvailableFieldSpecified;
            }
            set {
                this.quantityAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double averageCost {
            get {
                return this.averageCostField;
            }
            set {
                this.averageCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool averageCostSpecified {
            get {
                return this.averageCostFieldSpecified;
            }
            set {
                this.averageCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double lastPurchasePrice {
            get {
                return this.lastPurchasePriceField;
            }
            set {
                this.lastPurchasePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastPurchasePriceSpecified {
            get {
                return this.lastPurchasePriceFieldSpecified;
            }
            set {
                this.lastPurchasePriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnHandSpecified {
            get {
                return this.quantityOnHandFieldSpecified;
            }
            set {
                this.quantityOnHandFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
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
        public InventoryDetail inventoryDetail {
            get {
                return this.inventoryDetailField;
            }
            set {
                this.inventoryDetailField = value;
            }
        }

        /// <remarks/>
        public string serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
            }
        }

        /// <remarks/>
        public double orderPriority {
            get {
                return this.orderPriorityField;
            }
            set {
                this.orderPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderPrioritySpecified {
            get {
                return this.orderPriorityFieldSpecified;
            }
            set {
                this.orderPriorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }

        /// <remarks/>
        public ItemSource itemSource {
            get {
                return this.itemSourceField;
            }
            set {
                this.itemSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemSourceSpecified {
            get {
                return this.itemSourceFieldSpecified;
            }
            set {
                this.itemSourceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public RecordRef poVendor {
            get {
                return this.poVendorField;
            }
            set {
                this.poVendorField = value;
            }
        }

        /// <remarks/>
        public double poRate {
            get {
                return this.poRateField;
            }
            set {
                this.poRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool poRateSpecified {
            get {
                return this.poRateFieldSpecified;
            }
            set {
                this.poRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double percentComplete {
            get {
                return this.percentCompleteField;
            }
            set {
                this.percentCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentCompleteSpecified {
            get {
                return this.percentCompleteFieldSpecified;
            }
            set {
                this.percentCompleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double contribution {
            get {
                return this.contributionField;
            }
            set {
                this.contributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool contributionSpecified {
            get {
                return this.contributionFieldSpecified;
            }
            set {
                this.contributionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public WorkOrderItemItemCommitInventory commitInventory {
            get {
                return this.commitInventoryField;
            }
            set {
                this.commitInventoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commitInventorySpecified {
            get {
                return this.commitInventoryFieldSpecified;
            }
            set {
                this.commitInventoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime plannedIssueDate {
            get {
                return this.plannedIssueDateField;
            }
            set {
                this.plannedIssueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plannedIssueDateSpecified {
            get {
                return this.plannedIssueDateFieldSpecified;
            }
            set {
                this.plannedIssueDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef orderAllocationStrategy {
            get {
                return this.orderAllocationStrategyField;
            }
            set {
                this.orderAllocationStrategyField = value;
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
    }
}