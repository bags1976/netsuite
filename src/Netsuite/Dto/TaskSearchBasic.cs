namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TaskSearchBasic : SearchRecordBasic {

        private SearchDoubleField actualTimeField;

        private SearchMultiSelectField assignedField;

        private SearchMultiSelectField companyField;

        private SearchDateField completedDateField;

        private SearchMultiSelectField contactField;

        private SearchDateField createdDateField;

        private SearchDateField endDateField;

        private SearchDoubleField estimatedTimeField;

        private SearchDoubleField estimatedTimeOverrideField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isJobSummaryTaskField;

        private SearchBooleanField isJobTaskField;

        private SearchBooleanField isPrivateField;

        private SearchDateField lastModifiedDateField;

        private SearchLongField milestoneField;

        private SearchMultiSelectField ownerField;

        private SearchLongField percentCompleteField;

        private SearchLongField percentTimeCompleteField;

        private SearchEnumMultiSelectField priorityField;

        private SearchDateField startDateField;

        private SearchEnumMultiSelectField statusField;

        private SearchDoubleField timeRemainingField;

        private SearchStringField titleField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchDoubleField actualTime {
            get {
                return this.actualTimeField;
            }
            set {
                this.actualTimeField = value;
            }
        }

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
        public SearchMultiSelectField company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
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
        public SearchMultiSelectField contact {
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
        public SearchDateField endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedTime {
            get {
                return this.estimatedTimeField;
            }
            set {
                this.estimatedTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedTimeOverride {
            get {
                return this.estimatedTimeOverrideField;
            }
            set {
                this.estimatedTimeOverrideField = value;
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
        public SearchBooleanField isJobSummaryTask {
            get {
                return this.isJobSummaryTaskField;
            }
            set {
                this.isJobSummaryTaskField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isJobTask {
            get {
                return this.isJobTaskField;
            }
            set {
                this.isJobTaskField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isPrivate {
            get {
                return this.isPrivateField;
            }
            set {
                this.isPrivateField = value;
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
        public SearchLongField milestone {
            get {
                return this.milestoneField;
            }
            set {
                this.milestoneField = value;
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
        public SearchLongField percentComplete {
            get {
                return this.percentCompleteField;
            }
            set {
                this.percentCompleteField = value;
            }
        }

        /// <remarks/>
        public SearchLongField percentTimeComplete {
            get {
                return this.percentTimeCompleteField;
            }
            set {
                this.percentTimeCompleteField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
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
        public SearchDoubleField timeRemaining {
            get {
                return this.timeRemainingField;
            }
            set {
                this.timeRemainingField = value;
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