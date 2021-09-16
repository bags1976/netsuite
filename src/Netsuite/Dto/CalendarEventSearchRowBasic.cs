namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CalendarEventSearchRowBasic : SearchRowBasic {

        private SearchColumnEnumSelectField[] accessLevelField;

        private SearchColumnSelectField[] attendeeField;

        private SearchColumnSelectField[] companyField;

        private SearchColumnDateField[] completedDateField;

        private SearchColumnSelectField[] contactField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnStringField[] endTimeField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnDateField[] instanceEndField;

        private SearchColumnDateField[] instanceStartField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnStringField[] locationField;

        private SearchColumnStringField[] markdoneField;

        private SearchColumnStringField[] messageField;

        private SearchColumnSelectField[] organizerField;

        private SearchColumnSelectField[] ownerField;

        private SearchColumnStringField[] recurrenceField;

        private SearchColumnSelectField[] resourceField;

        private SearchColumnEnumSelectField[] responseField;

        private SearchColumnStringField[] startDateField;

        private SearchColumnStringField[] startTimeField;

        private SearchColumnEnumSelectField[] statusField;

        private SearchColumnStringField[] titleField;

        private SearchColumnSelectField[] transactionField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accessLevel")]
        public SearchColumnEnumSelectField[] accessLevel {
            get {
                return this.accessLevelField;
            }
            set {
                this.accessLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attendee")]
        public SearchColumnSelectField[] attendee {
            get {
                return this.attendeeField;
            }
            set {
                this.attendeeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("completedDate")]
        public SearchColumnDateField[] completedDate {
            get {
                return this.completedDateField;
            }
            set {
                this.completedDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("endTime")]
        public SearchColumnStringField[] endTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("instanceEnd")]
        public SearchColumnDateField[] instanceEnd {
            get {
                return this.instanceEndField;
            }
            set {
                this.instanceEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("instanceStart")]
        public SearchColumnDateField[] instanceStart {
            get {
                return this.instanceStartField;
            }
            set {
                this.instanceStartField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnStringField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("markdone")]
        public SearchColumnStringField[] markdone {
            get {
                return this.markdoneField;
            }
            set {
                this.markdoneField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("organizer")]
        public SearchColumnSelectField[] organizer {
            get {
                return this.organizerField;
            }
            set {
                this.organizerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("owner")]
        public SearchColumnSelectField[] owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurrence")]
        public SearchColumnStringField[] recurrence {
            get {
                return this.recurrenceField;
            }
            set {
                this.recurrenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resource")]
        public SearchColumnSelectField[] resource {
            get {
                return this.resourceField;
            }
            set {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("response")]
        public SearchColumnEnumSelectField[] response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDate")]
        public SearchColumnStringField[] startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startTime")]
        public SearchColumnStringField[] startTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnEnumSelectField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("transaction")]
        public SearchColumnSelectField[] transaction {
            get {
                return this.transactionField;
            }
            set {
                this.transactionField = value;
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