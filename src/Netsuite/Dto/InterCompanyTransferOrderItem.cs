namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class InterCompanyTransferOrderItem {

        private RecordRef itemField;

        private long lineField;

        private bool lineFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double quantityBackOrderedField;

        private bool quantityBackOrderedFieldSpecified;

        private double quantityCommittedField;

        private bool quantityCommittedFieldSpecified;

        private double quantityFulfilledField;

        private bool quantityFulfilledFieldSpecified;

        private double quantityReceivedField;

        private bool quantityReceivedFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private double rateField;

        private bool rateFieldSpecified;

        private RecordRef unitsField;

        private double amountField;

        private bool amountFieldSpecified;

        private string descriptionField;

        private InventoryDetail inventoryDetailField;

        private TransferOrderItemCommitInventory commitInventoryField;

        private bool commitInventoryFieldSpecified;

        private CustomFieldRef[] optionsField;

        private RecordRef departmentField;

        private RecordRef classField;

        private double lastPurchasePriceField;

        private bool lastPurchasePriceFieldSpecified;

        private double averageCostField;

        private bool averageCostFieldSpecified;

        private CustomFieldRef[] customFieldListField;

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
        public double quantityFulfilled {
            get {
                return this.quantityFulfilledField;
            }
            set {
                this.quantityFulfilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityFulfilledSpecified {
            get {
                return this.quantityFulfilledFieldSpecified;
            }
            set {
                this.quantityFulfilledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityReceived {
            get {
                return this.quantityReceivedField;
            }
            set {
                this.quantityReceivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityReceivedSpecified {
            get {
                return this.quantityReceivedFieldSpecified;
            }
            set {
                this.quantityReceivedFieldSpecified = value;
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
        public double rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
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
        public double amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
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
        public InventoryDetail inventoryDetail {
            get {
                return this.inventoryDetailField;
            }
            set {
                this.inventoryDetailField = value;
            }
        }

        /// <remarks/>
        public TransferOrderItemCommitInventory commitInventory {
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