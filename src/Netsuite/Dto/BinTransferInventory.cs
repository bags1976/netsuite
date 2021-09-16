namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class BinTransferInventory {

        private long lineField;

        private bool lineFieldSpecified;

        private RecordRef itemField;

        private string descriptionField;

        private string preferredBinField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private string itemUnitsLabelField;

        private InventoryDetail inventoryDetailField;

        private string fromBinsField;

        private string toBinsField;

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
        public string preferredBin {
            get {
                return this.preferredBinField;
            }
            set {
                this.preferredBinField = value;
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
        public string itemUnitsLabel {
            get {
                return this.itemUnitsLabelField;
            }
            set {
                this.itemUnitsLabelField = value;
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
        public string fromBins {
            get {
                return this.fromBinsField;
            }
            set {
                this.fromBinsField = value;
            }
        }

        /// <remarks/>
        public string toBins {
            get {
                return this.toBinsField;
            }
            set {
                this.toBinsField = value;
            }
        }
    }
}