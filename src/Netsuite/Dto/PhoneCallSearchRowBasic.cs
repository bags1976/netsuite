namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PhoneCallSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] accessLevelField;

        private SearchColumnSelectField[] assignedField;

        private SearchColumnSelectField[] companyField;

        private SearchColumnDateField[] completedDateField;

        private SearchColumnSelectField[] contactField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnStringField[] markdoneField;

        private SearchColumnStringField[] messageField;

        private SearchColumnSelectField[] ownerField;

        private SearchColumnStringField[] phoneField;

        private SearchColumnEnumSelectField[] priorityField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnDateField[] startTimeField;

        private SearchColumnEnumSelectField[] statusField;

        private SearchColumnStringField[] titleField;

        private SearchColumnSelectField[] transactionField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accessLevel")]
        public SearchColumnStringField[] accessLevel {
            get {
                return this.accessLevelField;
            }
            set {
                this.accessLevelField = value;
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("phone")]
        public SearchColumnStringField[] phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("priority")]
        public SearchColumnEnumSelectField[] priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("startTime")]
        public SearchColumnDateField[] startTime {
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