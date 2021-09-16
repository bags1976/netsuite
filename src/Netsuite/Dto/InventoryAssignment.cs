namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InventoryAssignment {

        private string internalIdField;

        private RecordRef issueInventoryNumberField;

        private string receiptInventoryNumberField;

        private RecordRef binNumberField;

        private RecordRef toBinNumberField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private System.DateTime expirationDateField;

        private bool expirationDateFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private RecordRef inventoryStatusField;

        private RecordRef toInventoryStatusField;

        /// <remarks/>
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef issueInventoryNumber {
            get {
                return this.issueInventoryNumberField;
            }
            set {
                this.issueInventoryNumberField = value;
            }
        }

        /// <remarks/>
        public string receiptInventoryNumber {
            get {
                return this.receiptInventoryNumberField;
            }
            set {
                this.receiptInventoryNumberField = value;
            }
        }

        /// <remarks/>
        public RecordRef binNumber {
            get {
                return this.binNumberField;
            }
            set {
                this.binNumberField = value;
            }
        }

        /// <remarks/>
        public RecordRef toBinNumber {
            get {
                return this.toBinNumberField;
            }
            set {
                this.toBinNumberField = value;
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
        public RecordRef inventoryStatus {
            get {
                return this.inventoryStatusField;
            }
            set {
                this.inventoryStatusField = value;
            }
        }

        /// <remarks/>
        public RecordRef toInventoryStatus {
            get {
                return this.toInventoryStatusField;
            }
            set {
                this.toInventoryStatusField = value;
            }
        }
    }
}