namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class FolderSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField classField;

        private SearchMultiSelectField departmentField;

        private SearchStringField descriptionField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField groupField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isTopLevelField;

        private SearchDateField lastModifiedDateField;

        private SearchMultiSelectField locationField;

        private SearchStringField nameField;

        private SearchLongField numFilesField;

        private SearchMultiSelectField ownerField;

        private SearchMultiSelectField parentField;

        private SearchMultiSelectField predecessorField;

        private SearchBooleanField privateField;

        private SearchLongField sizeField;

        private SearchMultiSelectField subsidiaryField;

        /// <remarks/>
        public SearchMultiSelectField @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public SearchMultiSelectField group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
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
        public SearchBooleanField isTopLevel {
            get {
                return this.isTopLevelField;
            }
            set {
                this.isTopLevelField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public SearchLongField numFiles {
            get {
                return this.numFilesField;
            }
            set {
                this.numFilesField = value;
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
        public SearchMultiSelectField predecessor {
            get {
                return this.predecessorField;
            }
            set {
                this.predecessorField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField @private {
            get {
                return this.privateField;
            }
            set {
                this.privateField = value;
            }
        }

        /// <remarks/>
        public SearchLongField size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }
    }
}