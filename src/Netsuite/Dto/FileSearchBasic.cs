namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class FileSearchBasic : SearchRecordBasic {

        private SearchBooleanField availableWithoutLoginField;

        private SearchDateField createdField;

        private SearchDateField dateViewedField;

        private SearchStringField descriptionField;

        private SearchLongField documentSizeField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchEnumMultiSelectField fileTypeField;

        private SearchMultiSelectField folderField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isAvailableField;

        private SearchBooleanField isLinkField;

        private SearchDateField modifiedField;

        private SearchStringField nameField;

        private SearchMultiSelectField ownerField;

        private SearchStringField urlField;

        /// <remarks/>
        public SearchBooleanField availableWithoutLogin {
            get {
                return this.availableWithoutLoginField;
            }
            set {
                this.availableWithoutLoginField = value;
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
        public SearchDateField dateViewed {
            get {
                return this.dateViewedField;
            }
            set {
                this.dateViewedField = value;
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
        public SearchLongField documentSize {
            get {
                return this.documentSizeField;
            }
            set {
                this.documentSizeField = value;
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
        public SearchEnumMultiSelectField fileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
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
        public SearchBooleanField isAvailable {
            get {
                return this.isAvailableField;
            }
            set {
                this.isAvailableField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isLink {
            get {
                return this.isLinkField;
            }
            set {
                this.isLinkField = value;
            }
        }

        /// <remarks/>
        public SearchDateField modified {
            get {
                return this.modifiedField;
            }
            set {
                this.modifiedField = value;
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
        public SearchStringField url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
}