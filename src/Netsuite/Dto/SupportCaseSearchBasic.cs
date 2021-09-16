namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class SupportCaseSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField assignedField;

        private SearchBooleanField awaitingReplyField;

        private SearchStringField caseNumberField;

        private SearchMultiSelectField categoryField;

        private SearchDateField closedDateField;

        private SearchStringField companyField;

        private SearchStringField contactField;

        private SearchDateField createdDateField;

        private SearchStringField emailField;

        private SearchMultiSelectField escalateToField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchBooleanField helpDeskField;

        private SearchStringField inboundEmailField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchMultiSelectField issueField;

        private SearchMultiSelectField itemField;

        private SearchBooleanField lastMessageField;

        private SearchDateField lastModifiedDateField;

        private SearchDateField lastReopenedDateField;

        private SearchBooleanField lockedField;

        private SearchStringField messageField;

        private SearchMultiSelectField messageAuthorField;

        private SearchDateField messageDateField;

        private SearchBooleanField messageTypeField;

        private SearchMultiSelectField moduleField;

        private SearchLongField numberField;

        private SearchMultiSelectField originField;

        private SearchMultiSelectField priorityField;

        private SearchMultiSelectField productField;

        private SearchMultiSelectField profileField;

        private SearchStringField serialNumberField;

        private SearchEnumMultiSelectField stageField;

        private SearchDateField startDateField;

        private SearchMultiSelectField statusField;

        private SearchMultiSelectField subsidiaryField;

        private SearchStringField titleField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField assigned {
            get {
                return this.assignedField;
            }
            set {
                this.assignedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField awaitingReply {
            get {
                return this.awaitingReplyField;
            }
            set {
                this.awaitingReplyField = value;
            }
        }

        /// <remarks/>
        public SearchStringField caseNumber {
            get {
                return this.caseNumberField;
            }
            set {
                this.caseNumberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public SearchDateField closedDate {
            get {
                return this.closedDateField;
            }
            set {
                this.closedDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public SearchStringField contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public SearchDateField createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField escalateTo {
            get {
                return this.escalateToField;
            }
            set {
                this.escalateToField = value;
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
        public SearchBooleanField helpDesk {
            get {
                return this.helpDeskField;
            }
            set {
                this.helpDeskField = value;
            }
        }

        /// <remarks/>
        public SearchStringField inboundEmail {
            get {
                return this.inboundEmailField;
            }
            set {
                this.inboundEmailField = value;
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
        public SearchMultiSelectField issue {
            get {
                return this.issueField;
            }
            set {
                this.issueField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField lastMessage {
            get {
                return this.lastMessageField;
            }
            set {
                this.lastMessageField = value;
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
        public SearchDateField lastReopenedDate {
            get {
                return this.lastReopenedDateField;
            }
            set {
                this.lastReopenedDateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField locked {
            get {
                return this.lockedField;
            }
            set {
                this.lockedField = value;
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
        public SearchMultiSelectField messageAuthor {
            get {
                return this.messageAuthorField;
            }
            set {
                this.messageAuthorField = value;
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
        public SearchBooleanField messageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField module {
            get {
                return this.moduleField;
            }
            set {
                this.moduleField = value;
            }
        }

        /// <remarks/>
        public SearchLongField number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }

        /// <remarks/>
        public SearchStringField serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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