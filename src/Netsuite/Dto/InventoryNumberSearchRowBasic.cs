namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InventoryNumberSearchRowBasic : SearchRowBasic {

        private SearchColumnDateField[] expirationDateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnStringField[] inventoryNumberField;

        private SearchColumnBooleanField[] isonhandField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnStringField[] memoField;

        private SearchColumnDoubleField[] quantityavailableField;

        private SearchColumnDoubleField[] quantityintransitField;

        private SearchColumnDoubleField[] quantityonhandField;

        private SearchColumnDoubleField[] quantityonorderField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expirationDate")]
        public SearchColumnDateField[] expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
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
        public SearchColumnStringField[] inventoryNumber {
            get {
                return this.inventoryNumberField;
            }
            set {
                this.inventoryNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isonhand")]
        public SearchColumnBooleanField[] isonhand {
            get {
                return this.isonhandField;
            }
            set {
                this.isonhandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnSelectField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityavailable")]
        public SearchColumnDoubleField[] quantityavailable {
            get {
                return this.quantityavailableField;
            }
            set {
                this.quantityavailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityintransit")]
        public SearchColumnDoubleField[] quantityintransit {
            get {
                return this.quantityintransitField;
            }
            set {
                this.quantityintransitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityonhand")]
        public SearchColumnDoubleField[] quantityonhand {
            get {
                return this.quantityonhandField;
            }
            set {
                this.quantityonhandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityonorder")]
        public SearchColumnDoubleField[] quantityonorder {
            get {
                return this.quantityonorderField;
            }
            set {
                this.quantityonorderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}