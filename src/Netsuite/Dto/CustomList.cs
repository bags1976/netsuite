namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomList : Record {

        private string nameField;

        private RecordRef ownerField;

        private bool isOrderedField;

        private bool isOrderedFieldSpecified;

        private string descriptionField;

        private bool isMatrixOptionField;

        private bool isMatrixOptionFieldSpecified;

        private string scriptIdField;

        private bool convertToCustomRecordField;

        private bool convertToCustomRecordFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private CustomListCustomValueList customValueListField;

        private CustomListTranslationsList translationsListField;

        private string internalIdField;

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public RecordRef owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public bool isOrdered {
            get {
                return this.isOrderedField;
            }
            set {
                this.isOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOrderedSpecified {
            get {
                return this.isOrderedFieldSpecified;
            }
            set {
                this.isOrderedFieldSpecified = value;
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
        public bool isMatrixOption {
            get {
                return this.isMatrixOptionField;
            }
            set {
                this.isMatrixOptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMatrixOptionSpecified {
            get {
                return this.isMatrixOptionFieldSpecified;
            }
            set {
                this.isMatrixOptionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string scriptId {
            get {
                return this.scriptIdField;
            }
            set {
                this.scriptIdField = value;
            }
        }

        /// <remarks/>
        public bool convertToCustomRecord {
            get {
                return this.convertToCustomRecordField;
            }
            set {
                this.convertToCustomRecordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool convertToCustomRecordSpecified {
            get {
                return this.convertToCustomRecordFieldSpecified;
            }
            set {
                this.convertToCustomRecordFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomListCustomValueList customValueList {
            get {
                return this.customValueListField;
            }
            set {
                this.customValueListField = value;
            }
        }

        /// <remarks/>
        public CustomListTranslationsList translationsList {
            get {
                return this.translationsListField;
            }
            set {
                this.translationsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }
    }
}