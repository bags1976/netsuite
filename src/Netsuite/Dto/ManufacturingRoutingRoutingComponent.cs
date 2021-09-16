namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingRoutingRoutingComponent {

        private string itemNameField;

        private string revisionField;

        private string descriptionField;

        private double yieldField;

        private bool yieldFieldSpecified;

        private double bomQuantityField;

        private bool bomQuantityFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private string unitsField;

        private RecordRef operationDisplayTextField;

        private long operationSequenceNumberField;

        private bool operationSequenceNumberFieldSpecified;

        private string componentField;

        private string itemField;

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
        public string revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
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
        public double yield {
            get {
                return this.yieldField;
            }
            set {
                this.yieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yieldSpecified {
            get {
                return this.yieldFieldSpecified;
            }
            set {
                this.yieldFieldSpecified = value;
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
        public string units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        public RecordRef operationDisplayText {
            get {
                return this.operationDisplayTextField;
            }
            set {
                this.operationDisplayTextField = value;
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
        public string component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }

        /// <remarks/>
        public string item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}