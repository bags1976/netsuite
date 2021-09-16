namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class WorkOrderCompletionComponent {

        private RecordRef itemField;

        private long operationSequenceNumberField;

        private bool operationSequenceNumberFieldSpecified;

        private double quantityPerField;

        private bool quantityPerFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private InventoryDetail componentInventoryDetailField;

        private long lineNumberField;

        private bool lineNumberFieldSpecified;

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
        public double quantityPer {
            get {
                return this.quantityPerField;
            }
            set {
                this.quantityPerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityPerSpecified {
            get {
                return this.quantityPerFieldSpecified;
            }
            set {
                this.quantityPerFieldSpecified = value;
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
        public InventoryDetail componentInventoryDetail {
            get {
                return this.componentInventoryDetailField;
            }
            set {
                this.componentInventoryDetailField = value;
            }
        }

        /// <remarks/>
        public long lineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineNumberSpecified {
            get {
                return this.lineNumberFieldSpecified;
            }
            set {
                this.lineNumberFieldSpecified = value;
            }
        }
    }
}