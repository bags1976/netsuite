namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class MessageSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField authorField;

        private SearchStringField authorEmailField;

        private SearchStringField bccField;

        private SearchStringField ccField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchBooleanField hasAttachmentField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField internalOnlyField;

        private SearchStringField messageField;

        private SearchDateField messageDateField;

        private SearchEnumMultiSelectField messageTypeField;

        private SearchMultiSelectField recipientField;

        private SearchStringField recipientEmailField;

        private SearchStringField subjectField;

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
        public SearchStringField authorEmail {
            get {
                return this.authorEmailField;
            }
            set {
                this.authorEmailField = value;
            }
        }

        /// <remarks/>
        public SearchStringField bcc {
            get {
                return this.bccField;
            }
            set {
                this.bccField = value;
            }
        }

        /// <remarks/>
        public SearchStringField cc {
            get {
                return this.ccField;
            }
            set {
                this.ccField = value;
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
        public SearchBooleanField hasAttachment {
            get {
                return this.hasAttachmentField;
            }
            set {
                this.hasAttachmentField = value;
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
        public SearchBooleanField internalOnly {
            get {
                return this.internalOnlyField;
            }
            set {
                this.internalOnlyField = value;
            }
        }

        /// <remarks/>
        public SearchStringField message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public SearchDateField messageDate {
            get {
                return this.messageDateField;
            }
            set {
                this.messageDateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField messageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        public SearchStringField recipientEmail {
            get {
                return this.recipientEmailField;
            }
            set {
                this.recipientEmailField = value;
            }
        }

        /// <remarks/>
        public SearchStringField subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
    }
}