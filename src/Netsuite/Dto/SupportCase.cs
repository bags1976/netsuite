namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:support_2021_1.lists.webservices.netsuite.com")]
    public partial class SupportCase : Record {

        private string escalationMessageField;

        private System.DateTime lastReopenedDateField;

        private bool lastReopenedDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private string incomingMessageField;

        private RecordRef insertSolutionField;

        private string outgoingMessageField;

        private string searchSolutionField;

        private bool emailFormField;

        private bool emailFormFieldSpecified;

        private string newSolutionFromMsgField;

        private bool internalOnlyField;

        private bool internalOnlyFieldSpecified;

        private RecordRef customFormField;

        private string titleField;

        private string caseNumberField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private System.DateTime lastMessageDateField;

        private bool lastMessageDateFieldSpecified;

        private RecordRef companyField;

        private RecordRef profileField;

        private RecordRef subsidiaryField;

        private RecordRef contactField;

        private string emailField;

        private string phoneField;

        private RecordRef productField;

        private RecordRef moduleField;

        private RecordRef itemField;

        private RecordRef serialNumberField;

        private string inboundEmailField;

        private RecordRef issueField;

        private RecordRef statusField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private RecordRef priorityField;

        private RecordRef originField;

        private RecordRef categoryField;

        private RecordRef assignedField;

        private bool helpDeskField;

        private bool helpDeskFieldSpecified;

        private RecordRef[] emailEmployeesListField;

        private SupportCaseEscalateToList escalateToListField;

        private SupportCaseTimeItemList timeItemListField;

        private SupportCaseSolutionsList solutionsListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string escalationMessage {
            get {
                return this.escalationMessageField;
            }
            set {
                this.escalationMessageField = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastReopenedDate {
            get {
                return this.lastReopenedDateField;
            }
            set {
                this.lastReopenedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastReopenedDateSpecified {
            get {
                return this.lastReopenedDateFieldSpecified;
            }
            set {
                this.lastReopenedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string incomingMessage {
            get {
                return this.incomingMessageField;
            }
            set {
                this.incomingMessageField = value;
            }
        }

        /// <remarks/>
        public RecordRef insertSolution {
            get {
                return this.insertSolutionField;
            }
            set {
                this.insertSolutionField = value;
            }
        }

        /// <remarks/>
        public string outgoingMessage {
            get {
                return this.outgoingMessageField;
            }
            set {
                this.outgoingMessageField = value;
            }
        }

        /// <remarks/>
        public string searchSolution {
            get {
                return this.searchSolutionField;
            }
            set {
                this.searchSolutionField = value;
            }
        }

        /// <remarks/>
        public bool emailForm {
            get {
                return this.emailFormField;
            }
            set {
                this.emailFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emailFormSpecified {
            get {
                return this.emailFormFieldSpecified;
            }
            set {
                this.emailFormFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string newSolutionFromMsg {
            get {
                return this.newSolutionFromMsgField;
            }
            set {
                this.newSolutionFromMsgField = value;
            }
        }

        /// <remarks/>
        public bool internalOnly {
            get {
                return this.internalOnlyField;
            }
            set {
                this.internalOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool internalOnlySpecified {
            get {
                return this.internalOnlyFieldSpecified;
            }
            set {
                this.internalOnlyFieldSpecified = value;
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
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string caseNumber {
            get {
                return this.caseNumberField;
            }
            set {
                this.caseNumberField = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdDateSpecified {
            get {
                return this.createdDateFieldSpecified;
            }
            set {
                this.createdDateFieldSpecified = value;
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
        public System.DateTime lastMessageDate {
            get {
                return this.lastMessageDateField;
            }
            set {
                this.lastMessageDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastMessageDateSpecified {
            get {
                return this.lastMessageDateFieldSpecified;
            }
            set {
                this.lastMessageDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public RecordRef profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public RecordRef contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public RecordRef product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }

        /// <remarks/>
        public RecordRef module {
            get {
                return this.moduleField;
            }
            set {
                this.moduleField = value;
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
        public RecordRef serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        public string inboundEmail {
            get {
                return this.inboundEmailField;
            }
            set {
                this.inboundEmailField = value;
            }
        }

        /// <remarks/>
        public RecordRef issue {
            get {
                return this.issueField;
            }
            set {
                this.issueField = value;
            }
        }

        /// <remarks/>
        public RecordRef status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public RecordRef origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }

        /// <remarks/>
        public RecordRef category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public RecordRef assigned {
            get {
                return this.assignedField;
            }
            set {
                this.assignedField = value;
            }
        }

        /// <remarks/>
        public bool helpDesk {
            get {
                return this.helpDeskField;
            }
            set {
                this.helpDeskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool helpDeskSpecified {
            get {
                return this.helpDeskFieldSpecified;
            }
            set {
                this.helpDeskFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("emailEmployees", IsNullable=false)]
        public RecordRef[] emailEmployeesList {
            get {
                return this.emailEmployeesListField;
            }
            set {
                this.emailEmployeesListField = value;
            }
        }

        /// <remarks/>
        public SupportCaseEscalateToList escalateToList {
            get {
                return this.escalateToListField;
            }
            set {
                this.escalateToListField = value;
            }
        }

        /// <remarks/>
        public SupportCaseTimeItemList timeItemList {
            get {
                return this.timeItemListField;
            }
            set {
                this.timeItemListField = value;
            }
        }

        /// <remarks/>
        public SupportCaseSolutionsList solutionsList {
            get {
                return this.solutionsListField;
            }
            set {
                this.solutionsListField = value;
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