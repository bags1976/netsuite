namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class ItemReceiptItem {

        private bool itemReceiveField;

        private bool itemReceiveFieldSpecified;

        private string jobNameField;

        private RecordRef itemField;

        private long orderLineField;

        private bool orderLineFieldSpecified;

        private long lineField;

        private bool lineFieldSpecified;

        private string itemNameField;

        private string descriptionField;

        private RecordRef locationField;

        private double onHandField;

        private bool onHandFieldSpecified;

        private double quantityRemainingField;

        private bool quantityRemainingFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private string unitsDisplayField;

        private double unitCostOverrideField;

        private bool unitCostOverrideFieldSpecified;

        private InventoryDetail inventoryDetailField;

        private string serialNumbersField;

        private string binNumbersField;

        private System.DateTime expirationDateField;

        private bool expirationDateFieldSpecified;

        private string rateField;

        private string currencyField;

        private bool restockField;

        private bool restockFieldSpecified;

        private TransactionBillVarianceStatus billVarianceStatusField;

        private bool billVarianceStatusFieldSpecified;

        private bool isDropShipmentField;

        private bool isDropShipmentFieldSpecified;

        private CustomFieldRef[] optionsField;

        private LandedCost landedCostField;

        private CustomFieldRef[] customFieldListField;

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
        public string jobName {
            get {
                return this.jobNameField;
            }
            set {
                this.jobNameField = value;
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
        public double unitCostOverride {
            get {
                return this.unitCostOverrideField;
            }
            set {
                this.unitCostOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitCostOverrideSpecified {
            get {
                return this.unitCostOverrideFieldSpecified;
            }
            set {
                this.unitCostOverrideFieldSpecified = value;
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
        public string binNumbers {
            get {
                return this.binNumbersField;
            }
            set {
                this.binNumbersField = value;
            }
        }

        /// <remarks/>
        public System.DateTime expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified {
            get {
                return this.expirationDateFieldSpecified;
            }
            set {
                this.expirationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public bool restock {
            get {
                return this.restockField;
            }
            set {
                this.restockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool restockSpecified {
            get {
                return this.restockFieldSpecified;
            }
            set {
                this.restockFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TransactionBillVarianceStatus billVarianceStatus {
            get {
                return this.billVarianceStatusField;
            }
            set {
                this.billVarianceStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billVarianceStatusSpecified {
            get {
                return this.billVarianceStatusFieldSpecified;
            }
            set {
                this.billVarianceStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isDropShipment {
            get {
                return this.isDropShipmentField;
            }
            set {
                this.isDropShipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDropShipmentSpecified {
            get {
                return this.isDropShipmentFieldSpecified;
            }
            set {
                this.isDropShipmentFieldSpecified = value;
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
        public LandedCost landedCost {
            get {
                return this.landedCostField;
            }
            set {
                this.landedCostField = value;
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