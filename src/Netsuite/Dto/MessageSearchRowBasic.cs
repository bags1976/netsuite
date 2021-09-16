namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class MessageSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] authorField;

        private SearchColumnStringField[] authorEmailField;

        private SearchColumnStringField[] bccField;

        private SearchColumnStringField[] ccField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnBooleanField[] hasAttachmentField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] internalOnlyField;

        private SearchColumnBooleanField[] isEmailedField;

        private SearchColumnBooleanField[] isIncomingField;

        private SearchColumnStringField[] messageField;

        private SearchColumnDateField[] messageDateField;

        private SearchColumnEnumSelectField[] messageTypeField;

        private SearchColumnSelectField[] recipientField;

        private SearchColumnStringField[] recipientEmailField;

        private SearchColumnStringField[] subjectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("author")]
        public SearchColumnSelectField[] author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("authorEmail")]
        public SearchColumnStringField[] authorEmail {
            get {
                return this.authorEmailField;
            }
            set {
                this.authorEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bcc")]
        public SearchColumnStringField[] bcc {
            get {
                return this.bccField;
            }
            set {
                this.bccField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cc")]
        public SearchColumnStringField[] cc {
            get {
                return this.ccField;
            }
            set {
                this.ccField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("hasAttachment")]
        public SearchColumnBooleanField[] hasAttachment {
            get {
                return this.hasAttachmentField;
            }
            set {
                this.hasAttachmentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("internalOnly")]
        public SearchColumnBooleanField[] internalOnly {
            get {
                return this.internalOnlyField;
            }
            set {
                this.internalOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isEmailed")]
        public SearchColumnBooleanField[] isEmailed {
            get {
                return this.isEmailedField;
            }
            set {
                this.isEmailedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isIncoming")]
        public SearchColumnBooleanField[] isIncoming {
            get {
                return this.isIncomingField;
            }
            set {
                this.isIncomingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public SearchColumnStringField[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("messageDate")]
        public SearchColumnDateField[] messageDate {
            get {
                return this.messageDateField;
            }
            set {
                this.messageDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("messageType")]
        public SearchColumnEnumSelectField[] messageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recipient")]
        public SearchColumnSelectField[] recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recipientEmail")]
        public SearchColumnStringField[] recipientEmail {
            get {
                return this.recipientEmailField;
            }
            set {
                this.recipientEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subject")]
        public SearchColumnStringField[] subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
    }
}