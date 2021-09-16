namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:communication_2021_1.general.webservices.netsuite.com")]
    public partial class Note : Record {

        private string titleField;

        private RecordRef noteTypeField;

        private NoteDirection directionField;

        private bool directionFieldSpecified;

        private System.DateTime noteDateField;

        private bool noteDateFieldSpecified;

        private string noteField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef activityField;

        private RecordRef authorField;

        private RecordRef entityField;

        private RecordRef folderField;

        private RecordRef itemField;

        private RecordRef mediaField;

        private RecordRef recordField;

        private RecordRef recordTypeField;

        private RecordRef topicField;

        private RecordRef transactionField;

        private RecordRef customFormField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public RecordRef noteType {
            get {
                return this.noteTypeField;
            }
            set {
                this.noteTypeField = value;
            }
        }

        /// <remarks/>
        public NoteDirection direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directionSpecified {
            get {
                return this.directionFieldSpecified;
            }
            set {
                this.directionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime noteDate {
            get {
                return this.noteDateField;
            }
            set {
                this.noteDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noteDateSpecified {
            get {
                return this.noteDateFieldSpecified;
            }
            set {
                this.noteDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedDateSpecified {
            get {
                return this.lastModifiedDateFieldSpecified;
            }
            set {
                this.lastModifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef activity {
            get {
                return this.activityField;
            }
            set {
                this.activityField = value;
            }
        }

        /// <remarks/>
        public RecordRef author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public RecordRef folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public RecordRef media {
            get {
                return this.mediaField;
            }
            set {
                this.mediaField = value;
            }
        }

        /// <remarks/>
        public RecordRef record {
            get {
                return this.recordField;
            }
            set {
                this.recordField = value;
            }
        }

        /// <remarks/>
        public RecordRef recordType {
            get {
                return this.recordTypeField;
            }
            set {
                this.recordTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef topic {
            get {
                return this.topicField;
            }
            set {
                this.topicField = value;
            }
        }

        /// <remarks/>
        public RecordRef transaction {
            get {
                return this.transactionField;
            }
            set {
                this.transactionField = value;
            }
        }

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}