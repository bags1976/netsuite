namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BomRevisionComponentSearchBasic : SearchRecordBasic {

        private SearchDoubleField bomQuantityField;

        private SearchMultiSelectField bomRevisionField;

        private SearchDoubleField componentYieldField;

        private SearchStringField descriptionField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField itemField;

        private SearchEnumMultiSelectField itemSourceField;

        private SearchStringField itemSubtypeField;

        private SearchMultiSelectField itemTypeField;

        private SearchLongField lineIdField;

        private SearchDoubleField quantityField;

        private SearchStringField unitsField;

        private SearchDoubleField weightField;

        /// <remarks/>
        public SearchDoubleField bomQuantity {
            get {
                return this.bomQuantityField;
            }
            set {
                this.bomQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField bomRevision {
            get {
                return this.bomRevisionField;
            }
            set {
                this.bomRevisionField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField componentYield {
            get {
                return this.componentYieldField;
            }
            set {
                this.componentYieldField = value;
            }
        }

        /// <remarks/>
        public SearchStringField description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField itemSource {
            get {
                return this.itemSourceField;
            }
            set {
                this.itemSourceField = value;
            }
        }

        /// <remarks/>
        public SearchStringField itemSubtype {
            get {
                return this.itemSubtypeField;
            }
            set {
                this.itemSubtypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField itemType {
            get {
                return this.itemTypeField;
            }
            set {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        public SearchLongField lineId {
            get {
                return this.lineIdField;
            }
            set {
                this.lineIdField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public SearchStringField units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
    }
}