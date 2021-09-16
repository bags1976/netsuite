namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class InventoryTransferInventory {

        private long lineField;

        private bool lineFieldSpecified;

        private RecordRef itemField;

        private string descriptionField;

        private RecordRef unitsField;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double adjustQtyByField;

        private bool adjustQtyByFieldSpecified;

        private string serialNumbersField;

        private string fromBinNumbersField;

        private string toBinNumbersField;

        private InventoryDetail inventoryDetailField;

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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
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
        public double adjustQtyBy {
            get {
                return this.adjustQtyByField;
            }
            set {
                this.adjustQtyByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adjustQtyBySpecified {
            get {
                return this.adjustQtyByFieldSpecified;
            }
            set {
                this.adjustQtyByFieldSpecified = value;
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
        public string fromBinNumbers {
            get {
                return this.fromBinNumbersField;
            }
            set {
                this.fromBinNumbersField = value;
            }
        }

        /// <remarks/>
        public string toBinNumbers {
            get {
                return this.toBinNumbersField;
            }
            set {
                this.toBinNumbersField = value;
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