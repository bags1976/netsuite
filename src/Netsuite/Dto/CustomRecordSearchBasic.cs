namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CustomRecordSearchBasic : SearchRecordBasic {

        private RecordRef recTypeField;

        private SearchBooleanField availableOfflineField;

        private SearchDateField createdField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchLongField idField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchDateField lastModifiedField;

        private SearchMultiSelectField lastModifiedByField;

        private SearchStringField nameField;

        private SearchMultiSelectField ownerField;

        private SearchMultiSelectField parentField;

        private SearchCustomField[] customFieldListField;

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
        public SearchBooleanField availableOffline {
            get {
                return this.availableOfflineField;
            }
            set {
                this.availableOfflineField = value;
            }
        }

        /// <remarks/>
        public SearchDateField created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchLongField id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastModified {
            get {
                return this.lastModifiedField;
            }
            set {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField lastModifiedBy {
            get {
                return this.lastModifiedByField;
            }
            set {
                this.lastModifiedByField = value;
            }
        }

        /// <remarks/>
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}