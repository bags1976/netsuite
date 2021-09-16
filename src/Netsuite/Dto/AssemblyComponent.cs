namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class AssemblyComponent {

        private RecordRef itemField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private InventoryDetail componentInventoryDetailField;

        private string componentNumbersField;

        private string binNumbersField;

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
        public InventoryDetail componentInventoryDetail {
            get {
                return this.componentInventoryDetailField;
            }
            set {
                this.componentInventoryDetailField = value;
            }
        }

        /// <remarks/>
        public string componentNumbers {
            get {
                return this.componentNumbersField;
            }
            set {
                this.componentNumbersField = value;
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