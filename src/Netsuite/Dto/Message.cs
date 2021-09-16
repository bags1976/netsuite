namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:communication_2021_1.general.webservices.netsuite.com")]
    public partial class Message : Record {

        private RecordRef authorField;

        private string authorEmailField;

        private RecordRef recipientField;

        private string recipientEmailField;

        private string ccField;

        private string bccField;

        private System.DateTime messageDateField;

        private bool messageDateFieldSpecified;

        private string recordNameField;

        private string recordTypeNameField;

        private string subjectField;

        private string messageField;

        private bool emailedField;

        private bool emailedFieldSpecified;

        private RecordRef activityField;

        private bool compressAttachmentsField;

        private bool compressAttachmentsFieldSpecified;

        private bool incomingField;

        private bool incomingFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef transactionField;

        private MessageMediaItemList mediaItemListField;

        private string dateTimeField;

        private string internalIdField;

        private string externalIdField;

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
        public string authorEmail {
            get {
                return this.authorEmailField;
            }
            set {
                this.authorEmailField = value;
            }
        }

        /// <remarks/>
        public RecordRef recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        public string recipientEmail {
            get {
                return this.recipientEmailField;
            }
            set {
                this.recipientEmailField = value;
            }
        }

        /// <remarks/>
        public string cc {
            get {
                return this.ccField;
            }
            set {
                this.ccField = value;
            }
        }

        /// <remarks/>
        public string bcc {
            get {
                return this.bccField;
            }
            set {
                this.bccField = value;
            }
        }

        /// <remarks/>
        public System.DateTime messageDate {
            get {
                return this.messageDateField;
            }
            set {
                this.messageDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool messageDateSpecified {
            get {
                return this.messageDateFieldSpecified;
            }
            set {
                this.messageDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string recordName {
            get {
                return this.recordNameField;
            }
            set {
                this.recordNameField = value;
            }
        }

        /// <remarks/>
        public string recordTypeName {
            get {
                return this.recordTypeNameField;
            }
            set {
                this.recordTypeNameField = value;
            }
        }

        /// <remarks/>
        public string subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public bool emailed {
            get {
                return this.emailedField;
            }
            set {
                this.emailedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emailedSpecified {
            get {
                return this.emailedFieldSpecified;
            }
            set {
                this.emailedFieldSpecified = value;
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
        public bool compressAttachments {
            get {
                return this.compressAttachmentsField;
            }
            set {
                this.compressAttachmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compressAttachmentsSpecified {
            get {
                return this.compressAttachmentsFieldSpecified;
            }
            set {
                this.compressAttachmentsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool incoming {
            get {
                return this.incomingField;
            }
            set {
                this.incomingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool incomingSpecified {
            get {
                return this.incomingFieldSpecified;
            }
            set {
                this.incomingFieldSpecified = value;
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
        public RecordRef transaction {
            get {
                return this.transactionField;
            }
            set {
                this.transactionField = value;
            }
        }

        /// <remarks/>
        public MessageMediaItemList mediaItemList {
            get {
                return this.mediaItemListField;
            }
            set {
                this.mediaItemListField = value;
            }
        }

        /// <remarks/>
        public string dateTime {
            get {
                return this.dateTimeField;
            }
            set {
                this.dateTimeField = value;
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