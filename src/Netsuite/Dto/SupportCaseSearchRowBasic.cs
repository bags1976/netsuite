namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class SupportCaseSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] assignedField;

        private SearchColumnBooleanField[] awaitingReplyField;

        private SearchColumnStringField[] caseNumberField;

        private SearchColumnSelectField[] categoryField;

        private SearchColumnSelectField[] companyField;

        private SearchColumnSelectField[] contactField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnEnumSelectField[] customerStageField;

        private SearchColumnStringField[] emailField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnSelectField[] escalateeField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnBooleanField[] helpDeskField;

        private SearchColumnStringField[] inboundEmailField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnSelectField[] issueField;

        private SearchColumnStringField[] issueNumberField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnDateField[] lastMessageDateField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnDateField[] lastReopenedDateField;

        private SearchColumnBooleanField[] lockedField;

        private SearchColumnSelectField[] moduleField;

        private SearchColumnSelectField[] originField;

        private SearchColumnSelectField[] priorityField;

        private SearchColumnSelectField[] productField;

        private SearchColumnSelectField[] profileField;

        private SearchColumnStringField[] serialNumberField;

        private SearchColumnEnumSelectField[] stageField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnSelectField[] statusField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnStringField[] titleField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("assigned")]
        public SearchColumnSelectField[] assigned {
            get {
                return this.assignedField;
            }
            set {
                this.assignedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("awaitingReply")]
        public SearchColumnBooleanField[] awaitingReply {
            get {
                return this.awaitingReplyField;
            }
            set {
                this.awaitingReplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseNumber")]
        public SearchColumnStringField[] caseNumber {
            get {
                return this.caseNumberField;
            }
            set {
                this.caseNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category")]
        public SearchColumnSelectField[] category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("company")]
        public SearchColumnSelectField[] company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public SearchColumnSelectField[] contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createdDate")]
        public SearchColumnDateField[] createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customerStage")]
        public SearchColumnEnumSelectField[] customerStage {
            get {
                return this.customerStageField;
            }
            set {
                this.customerStageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email")]
        public SearchColumnStringField[] email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endDate")]
        public SearchColumnDateField[] endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("escalatee")]
        public SearchColumnSelectField[] escalatee {
            get {
                return this.escalateeField;
            }
            set {
                this.escalateeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("helpDesk")]
        public SearchColumnBooleanField[] helpDesk {
            get {
                return this.helpDeskField;
            }
            set {
                this.helpDeskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inboundEmail")]
        public SearchColumnStringField[] inboundEmail {
            get {
                return this.inboundEmailField;
            }
            set {
                this.inboundEmailField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("issue")]
        public SearchColumnSelectField[] issue {
            get {
                return this.issueField;
            }
            set {
                this.issueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("issueNumber")]
        public SearchColumnStringField[] issueNumber {
            get {
                return this.issueNumberField;
            }
            set {
                this.issueNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnSelectField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastMessageDate")]
        public SearchColumnDateField[] lastMessageDate {
            get {
                return this.lastMessageDateField;
            }
            set {
                this.lastMessageDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModifiedDate")]
        public SearchColumnDateField[] lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastReopenedDate")]
        public SearchColumnDateField[] lastReopenedDate {
            get {
                return this.lastReopenedDateField;
            }
            set {
                this.lastReopenedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locked")]
        public SearchColumnBooleanField[] locked {
            get {
                return this.lockedField;
            }
            set {
                this.lockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("module")]
        public SearchColumnSelectField[] module {
            get {
                return this.moduleField;
            }
            set {
                this.moduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("origin")]
        public SearchColumnSelectField[] origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("priority")]
        public SearchColumnSelectField[] priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("product")]
        public SearchColumnSelectField[] product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("profile")]
        public SearchColumnSelectField[] profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serialNumber")]
        public SearchColumnStringField[] serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stage")]
        public SearchColumnEnumSelectField[] stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDate")]
        public SearchColumnDateField[] startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnSelectField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public SearchColumnStringField[] title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
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