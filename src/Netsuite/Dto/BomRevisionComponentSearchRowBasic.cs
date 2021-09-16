namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BomRevisionComponentSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] bomQuantityField;

        private SearchColumnSelectField[] bomRevisionField;

        private SearchColumnDoubleField[] componentYieldField;

        private SearchColumnStringField[] descriptionField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnEnumSelectField[] itemSourceField;

        private SearchColumnStringField[] itemSubtypeField;

        private SearchColumnSelectField[] itemTypeField;

        private SearchColumnLongField[] lineIdField;

        private SearchColumnDoubleField[] quantityField;

        private SearchColumnStringField[] unitsField;

        private SearchColumnDoubleField[] weightField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bomQuantity")]
        public SearchColumnDoubleField[] bomQuantity {
            get {
                return this.bomQuantityField;
            }
            set {
                this.bomQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bomRevision")]
        public SearchColumnSelectField[] bomRevision {
            get {
                return this.bomRevisionField;
            }
            set {
                this.bomRevisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("componentYield")]
        public SearchColumnDoubleField[] componentYield {
            get {
                return this.componentYieldField;
            }
            set {
                this.componentYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public SearchColumnStringField[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("itemSource")]
        public SearchColumnEnumSelectField[] itemSource {
            get {
                return this.itemSourceField;
            }
            set {
                this.itemSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemSubtype")]
        public SearchColumnStringField[] itemSubtype {
            get {
                return this.itemSubtypeField;
            }
            set {
                this.itemSubtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemType")]
        public SearchColumnSelectField[] itemType {
            get {
                return this.itemTypeField;
            }
            set {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lineId")]
        public SearchColumnLongField[] lineId {
            get {
                return this.lineIdField;
            }
            set {
                this.lineIdField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("units")]
        public SearchColumnStringField[] units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("weight")]
        public SearchColumnDoubleField[] weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
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