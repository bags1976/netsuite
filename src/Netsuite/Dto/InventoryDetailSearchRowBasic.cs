namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InventoryDetailSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] binNumberField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] inventoryNumberField;

        private SearchColumnDoubleField[] quantityField;

        private SearchColumnSelectField[] statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("binNumber")]
        public SearchColumnSelectField[] binNumber {
            get {
                return this.binNumberField;
            }
            set {
                this.binNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inventoryNumber")]
        public SearchColumnSelectField[] inventoryNumber {
            get {
                return this.inventoryNumberField;
            }
            set {
                this.inventoryNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantity")]
        public SearchColumnDoubleField[] quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnSelectField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
}