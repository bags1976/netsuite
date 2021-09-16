namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class ItemFulfillmentItem {

        private string jobNameField;

        private bool itemReceiveField;

        private bool itemReceiveFieldSpecified;

        private string itemNameField;

        private string descriptionField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private double onHandField;

        private bool onHandFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private string unitsDisplayField;

        private string createPoField;

        private InventoryDetail inventoryDetailField;

        private string binNumbersField;

        private string serialNumbersField;

        private string poNumField;

        private RecordRef itemField;

        private long orderLineField;

        private bool orderLineFieldSpecified;

        private double quantityRemainingField;

        private bool quantityRemainingFieldSpecified;

        private CustomFieldRef[] optionsField;

        private long shipGroupField;

        private bool shipGroupFieldSpecified;

        private bool itemIsFulfilledField;

        private bool itemIsFulfilledFieldSpecified;

        private RecordRef shipAddressField;

        private RecordRef shipMethodField;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public string jobName {
            get {
                return this.jobNameField;
            }
            set {
                this.jobNameField = value;
            }
        }

        /// <remarks/>
        public bool itemReceive {
            get {
                return this.itemReceiveField;
            }
            set {
                this.itemReceiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemReceiveSpecified {
            get {
                return this.itemReceiveFieldSpecified;
            }
            set {
                this.itemReceiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string itemName {
            get {
                return this.itemNameField;
            }
            set {
                this.itemNameField = value;
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
        public double onHand {
            get {
                return this.onHandField;
            }
            set {
                this.onHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool onHandSpecified {
            get {
                return this.onHandFieldSpecified;
            }
            set {
                this.onHandFieldSpecified = value;
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
        public string unitsDisplay {
            get {
                return this.unitsDisplayField;
            }
            set {
                this.unitsDisplayField = value;
            }
        }

        /// <remarks/>
        public string createPo {
            get {
                return this.createPoField;
            }
            set {
                this.createPoField = value;
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
        public string binNumbers {
            get {
                return this.binNumbersField;
            }
            set {
                this.binNumbersField = value;
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
        public string poNum {
            get {
                return this.poNumField;
            }
            set {
                this.poNumField = value;
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
        public long orderLine {
            get {
                return this.orderLineField;
            }
            set {
                this.orderLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderLineSpecified {
            get {
                return this.orderLineFieldSpecified;
            }
            set {
                this.orderLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityRemaining {
            get {
                return this.quantityRemainingField;
            }
            set {
                this.quantityRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityRemainingSpecified {
            get {
                return this.quantityRemainingFieldSpecified;
            }
            set {
                this.quantityRemainingFieldSpecified = value;
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
        public long shipGroup {
            get {
                return this.shipGroupField;
            }
            set {
                this.shipGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipGroupSpecified {
            get {
                return this.shipGroupFieldSpecified;
            }
            set {
                this.shipGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool itemIsFulfilled {
            get {
                return this.itemIsFulfilledField;
            }
            set {
                this.itemIsFulfilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemIsFulfilledSpecified {
            get {
                return this.itemIsFulfilledFieldSpecified;
            }
            set {
                this.itemIsFulfilledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef shipAddress {
            get {
                return this.shipAddressField;
            }
            set {
                this.shipAddressField = value;
            }
        }

        /// <remarks/>
        public RecordRef shipMethod {
            get {
                return this.shipMethodField;
            }
            set {
                this.shipMethodField = value;
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