namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CalendarEventSearchBasic : SearchRecordBasic {

        private SearchEnumMultiSelectField accessLevelField;

        private SearchMultiSelectField attendeeField;

        private SearchMultiSelectField calendarField;

        private SearchDateField completedDateField;

        private SearchDateField createdDateField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchDateField instanceStartField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isUpcomingEventField;

        private SearchDateField lastModifiedDateField;

        private SearchStringField locationField;

        private SearchStringField messageField;

        private SearchMultiSelectField organizerField;

        private SearchMultiSelectField ownerField;

        private SearchMultiSelectField resourceField;

        private SearchEnumMultiSelectField responseField;

        private SearchDateField startDateField;

        private SearchEnumMultiSelectField statusField;

        private SearchStringField titleField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchEnumMultiSelectField accessLevel {
            get {
                return this.accessLevelField;
            }
            set {
                this.accessLevelField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField attendee {
            get {
                return this.attendeeField;
            }
            set {
                this.attendeeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField calendar {
            get {
                return this.calendarField;
            }
            set {
                this.calendarField = value;
            }
        }

        /// <remarks/>
        public SearchDateField completedDate {
            get {
                return this.completedDateField;
            }
            set {
                this.completedDateField = value;
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
        public SearchDateField instanceStart {
            get {
                return this.instanceStartField;
            }
            set {
                this.instanceStartField = value;
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
        public SearchBooleanField isUpcomingEvent {
            get {
                return this.isUpcomingEventField;
            }
            set {
                this.isUpcomingEventField = value;
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
        public SearchStringField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public SearchMultiSelectField organizer {
            get {
                return this.organizerField;
            }
            set {
                this.organizerField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField resource {
            get {
                return this.resourceField;
            }
            set {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
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
        public SearchEnumMultiSelectField status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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