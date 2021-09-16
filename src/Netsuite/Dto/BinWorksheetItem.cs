namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class BinWorksheetItem {

        private RecordRef itemField;

        private string itemNameField;

        private string descriptionField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private string itemOnHandField;

        private string itemUnitsLabelField;

        private InventoryDetail inventoryDetailField;

        private string itemBinsField;

        private string itemBinNumbersField;

        private string itemBinListField;

        private string itemPreferBinField;

        private string itemBlankField;

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
        public string itemOnHand {
            get {
                return this.itemOnHandField;
            }
            set {
                this.itemOnHandField = value;
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
        public string itemBins {
            get {
                return this.itemBinsField;
            }
            set {
                this.itemBinsField = value;
            }
        }

        /// <remarks/>
        public string itemBinNumbers {
            get {
                return this.itemBinNumbersField;
            }
            set {
                this.itemBinNumbersField = value;
            }
        }

        /// <remarks/>
        public string itemBinList {
            get {
                return this.itemBinListField;
            }
            set {
                this.itemBinListField = value;
            }
        }

        /// <remarks/>
        public string itemPreferBin {
            get {
                return this.itemPreferBinField;
            }
            set {
                this.itemPreferBinField = value;
            }
        }

        /// <remarks/>
        public string itemBlank {
            get {
                return this.itemBlankField;
            }
            set {
                this.itemBlankField = value;
            }
        }
    }
}