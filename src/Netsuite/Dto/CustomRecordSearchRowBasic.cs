namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CustomRecordSearchRowBasic : SearchRowBasic {

        private RecordRef recTypeField;

        private SearchColumnStringField[] altNameField;

        private SearchColumnBooleanField[] availableOfflineField;

        private SearchColumnDateField[] createdField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnLongField[] idField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnDateField[] lastModifiedField;

        private SearchColumnSelectField[] lastModifiedByField;

        private SearchColumnStringField[] nameField;

        private SearchColumnSelectField[] ownerField;

        private SearchColumnSelectField[] parentField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        public RecordRef recType {
            get {
                return this.recTypeField;
            }
            set {
                this.recTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altName")]
        public SearchColumnStringField[] altName {
            get {
                return this.altNameField;
            }
            set {
                this.altNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("availableOffline")]
        public SearchColumnBooleanField[] availableOffline {
            get {
                return this.availableOfflineField;
            }
            set {
                this.availableOfflineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("created")]
        public SearchColumnDateField[] created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public SearchColumnLongField[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnBooleanField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModified")]
        public SearchColumnDateField[] lastModified {
            get {
                return this.lastModifiedField;
            }
            set {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModifiedBy")]
        public SearchColumnSelectField[] lastModifiedBy {
            get {
                return this.lastModifiedByField;
            }
            set {
                this.lastModifiedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("owner")]
        public SearchColumnSelectField[] owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parent")]
        public SearchColumnSelectField[] parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
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