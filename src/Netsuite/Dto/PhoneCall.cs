namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class PhoneCall : Record {

        private string messageField;

        private RecordRef companyField;

        private RecordRef contactField;

        private RecordRef supportCaseField;

        private RecordRef transactionField;

        private RecordRef milestoneField;

        private RecordRef customFormField;

        private string titleField;

        private RecordRef ownerField;

        private RecordRef assignedField;

        private bool sendEmailField;

        private bool sendEmailFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private bool timedEventField;

        private bool timedEventFieldSpecified;

        private System.DateTime completedDateField;

        private bool completedDateFieldSpecified;

        private string phoneField;

        private PhoneCallStatus statusField;

        private bool statusFieldSpecified;

        private PhoneCallPriority priorityField;

        private bool priorityFieldSpecified;

        private bool accessLevelField;

        private bool accessLevelFieldSpecified;

        private PhoneCallReminderType reminderTypeField;

        private bool reminderTypeFieldSpecified;

        private PhoneCallReminderMinutes reminderMinutesField;

        private bool reminderMinutesFieldSpecified;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private PhoneCallContactList contactListField;

        private PhoneCallTimeItemList timeItemListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public RecordRef company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
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
        public RecordRef supportCase {
            get {
                return this.supportCaseField;
            }
            set {
                this.supportCaseField = value;
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
        public RecordRef milestone {
            get {
                return this.milestoneField;
            }
            set {
                this.milestoneField = value;
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
        public RecordRef owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
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
        public bool sendEmail {
            get {
                return this.sendEmailField;
            }
            set {
                this.sendEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendEmailSpecified {
            get {
                return this.sendEmailFieldSpecified;
            }
            set {
                this.sendEmailFieldSpecified = value;
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
        public bool timedEvent {
            get {
                return this.timedEventField;
            }
            set {
                this.timedEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timedEventSpecified {
            get {
                return this.timedEventFieldSpecified;
            }
            set {
                this.timedEventFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime completedDate {
            get {
                return this.completedDateField;
            }
            set {
                this.completedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completedDateSpecified {
            get {
                return this.completedDateFieldSpecified;
            }
            set {
                this.completedDateFieldSpecified = value;
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
        public PhoneCallStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PhoneCallPriority priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prioritySpecified {
            get {
                return this.priorityFieldSpecified;
            }
            set {
                this.priorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool accessLevel {
            get {
                return this.accessLevelField;
            }
            set {
                this.accessLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessLevelSpecified {
            get {
                return this.accessLevelFieldSpecified;
            }
            set {
                this.accessLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PhoneCallReminderType reminderType {
            get {
                return this.reminderTypeField;
            }
            set {
                this.reminderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reminderTypeSpecified {
            get {
                return this.reminderTypeFieldSpecified;
            }
            set {
                this.reminderTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PhoneCallReminderMinutes reminderMinutes {
            get {
                return this.reminderMinutesField;
            }
            set {
                this.reminderMinutesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reminderMinutesSpecified {
            get {
                return this.reminderMinutesFieldSpecified;
            }
            set {
                this.reminderMinutesFieldSpecified = value;
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
        public PhoneCallContactList contactList {
            get {
                return this.contactListField;
            }
            set {
                this.contactListField = value;
            }
        }

        /// <remarks/>
        public PhoneCallTimeItemList timeItemList {
            get {
                return this.timeItemListField;
            }
            set {
                this.timeItemListField = value;
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