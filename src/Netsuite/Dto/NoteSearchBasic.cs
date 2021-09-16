namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class NoteSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField authorField;

        private SearchBooleanField directionField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchStringField noteField;

        private SearchDateField noteDateField;

        private SearchMultiSelectField noteTypeField;

        private SearchStringField titleField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
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
        public SearchStringField note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }

        /// <remarks/>
        public SearchDateField noteDate {
            get {
                return this.noteDateField;
            }
            set {
                this.noteDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField noteType {
            get {
                return this.noteTypeField;
            }
            set {
                this.noteTypeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
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