namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class CalendarEvent : Record {

        private RecordRef companyField;

        private RecordRef contactField;

        private RecordRef supportCaseField;

        private RecordRef transactionField;

        private long periodField;

        private bool periodFieldSpecified;

        private RecurrenceFrequency frequencyField;

        private bool frequencyFieldSpecified;

        private RecurrenceDow[] recurrenceDowMaskListField;

        private RecurrenceDow recurrenceDowField;

        private bool recurrenceDowFieldSpecified;

        private RecurrenceDowim recurrenceDowimField;

        private bool recurrenceDowimFieldSpecified;

        private System.DateTime seriesStartDateField;

        private bool seriesStartDateFieldSpecified;

        private System.DateTime endByDateField;

        private bool endByDateFieldSpecified;

        private bool noEndDateField;

        private bool noEndDateFieldSpecified;

        private bool sendEmailField;

        private bool sendEmailFieldSpecified;

        private RecordRef customFormField;

        private string titleField;

        private string recurrenceField;

        private string locationField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private bool allDayEventField;

        private bool allDayEventFieldSpecified;

        private bool timedEventField;

        private bool timedEventFieldSpecified;

        private CalendarEventReminderType reminderTypeField;

        private bool reminderTypeFieldSpecified;

        private CalendarEventReminderMinutes reminderMinutesField;

        private bool reminderMinutesFieldSpecified;

        private CalendarEventStatus statusField;

        private bool statusFieldSpecified;

        private CalendarEventAccessLevel accessLevelField;

        private bool accessLevelFieldSpecified;

        private RecordRef organizerField;

        private string messageField;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private System.DateTime[] exclusionDateListField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef ownerField;

        private CalendarEventAttendeeList attendeeListField;

        private CalendarEventResourceList resourceListField;

        private CalendarEventTimeItemList timeItemListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public long period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodSpecified {
            get {
                return this.periodFieldSpecified;
            }
            set {
                this.periodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecurrenceFrequency frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool frequencySpecified {
            get {
                return this.frequencyFieldSpecified;
            }
            set {
                this.frequencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recurrenceDowMask", Namespace="urn:common_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecurrenceDow[] recurrenceDowMaskList {
            get {
                return this.recurrenceDowMaskListField;
            }
            set {
                this.recurrenceDowMaskListField = value;
            }
        }

        /// <remarks/>
        public RecurrenceDow recurrenceDow {
            get {
                return this.recurrenceDowField;
            }
            set {
                this.recurrenceDowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurrenceDowSpecified {
            get {
                return this.recurrenceDowFieldSpecified;
            }
            set {
                this.recurrenceDowFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecurrenceDowim recurrenceDowim {
            get {
                return this.recurrenceDowimField;
            }
            set {
                this.recurrenceDowimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurrenceDowimSpecified {
            get {
                return this.recurrenceDowimFieldSpecified;
            }
            set {
                this.recurrenceDowimFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime seriesStartDate {
            get {
                return this.seriesStartDateField;
            }
            set {
                this.seriesStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool seriesStartDateSpecified {
            get {
                return this.seriesStartDateFieldSpecified;
            }
            set {
                this.seriesStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endByDate {
            get {
                return this.endByDateField;
            }
            set {
                this.endByDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endByDateSpecified {
            get {
                return this.endByDateFieldSpecified;
            }
            set {
                this.endByDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool noEndDate {
            get {
                return this.noEndDateField;
            }
            set {
                this.noEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noEndDateSpecified {
            get {
                return this.noEndDateFieldSpecified;
            }
            set {
                this.noEndDateFieldSpecified = value;
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
        public string recurrence {
            get {
                return this.recurrenceField;
            }
            set {
                this.recurrenceField = value;
            }
        }

        /// <remarks/>
        public string location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public bool allDayEvent {
            get {
                return this.allDayEventField;
            }
            set {
                this.allDayEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allDayEventSpecified {
            get {
                return this.allDayEventFieldSpecified;
            }
            set {
                this.allDayEventFieldSpecified = value;
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
        public CalendarEventReminderType reminderType {
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
        public CalendarEventReminderMinutes reminderMinutes {
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
        public CalendarEventStatus status {
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
        public CalendarEventAccessLevel accessLevel {
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
        public RecordRef organizer {
            get {
                return this.organizerField;
            }
            set {
                this.organizerField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("exclusionDate", IsNullable=false)]
        public System.DateTime[] exclusionDateList {
            get {
                return this.exclusionDateListField;
            }
            set {
                this.exclusionDateListField = value;
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
        public RecordRef owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public CalendarEventAttendeeList attendeeList {
            get {
                return this.attendeeListField;
            }
            set {
                this.attendeeListField = value;
            }
        }

        /// <remarks/>
        public CalendarEventResourceList resourceList {
            get {
                return this.resourceListField;
            }
            set {
                this.resourceListField = value;
            }
        }

        /// <remarks/>
        public CalendarEventTimeItemList timeItemList {
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