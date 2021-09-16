namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ResourceAllocationSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField allocationTypeField;

        private SearchEnumMultiSelectField allocationUnitField;

        private SearchEnumMultiSelectField approvalStatusField;

        private SearchMultiSelectField customerField;

        private SearchDateField endDateField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField nextApproverField;

        private SearchStringField notesField;

        private SearchDoubleField numberHoursField;

        private SearchDoubleField percentOfTimeField;

        private SearchMultiSelectField projectField;

        private SearchMultiSelectField requestedByField;

        private SearchMultiSelectField resourceField;

        private SearchDateField startDateField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField allocationType {
            get {
                return this.allocationTypeField;
            }
            set {
                this.allocationTypeField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField allocationUnit {
            get {
                return this.allocationUnitField;
            }
            set {
                this.allocationUnitField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        public SearchMultiSelectField nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
            }
        }

        /// <remarks/>
        public SearchStringField notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField numberHours {
            get {
                return this.numberHoursField;
            }
            set {
                this.numberHoursField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField percentOfTime {
            get {
                return this.percentOfTimeField;
            }
            set {
                this.percentOfTimeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField project {
            get {
                return this.projectField;
            }
            set {
                this.projectField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField requestedBy {
            get {
                return this.requestedByField;
            }
            set {
                this.requestedByField = value;
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
        public SearchDateField startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
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