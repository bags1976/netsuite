namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TimeBillSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField approvalStatusField;

        private SearchBooleanField approvedField;

        private SearchBooleanField billableField;

        private SearchMultiSelectField classField;

        private SearchMultiSelectField customerField;

        private SearchDateField dateField;

        private SearchDateField dateCreatedField;

        private SearchMultiSelectField departmentField;

        private SearchDoubleField durationField;

        private SearchMultiSelectField employeeField;

        private SearchBooleanField exemptField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField itemField;

        private SearchDateField lastModifiedField;

        private SearchMultiSelectField locationField;

        private SearchStringField memoField;

        private SearchBooleanField paidByPayrollField;

        private SearchBooleanField paidExternallyField;

        private SearchMultiSelectField payItemField;

        private SearchBooleanField productiveField;

        private SearchStringField rejectionNoteField;

        private SearchBooleanField statusField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField temporaryLocalJurisdictionField;

        private SearchMultiSelectField temporaryStateJurisdictionField;

        private SearchBooleanField timeModifiedField;

        private SearchMultiSelectField timeSheetField;

        private SearchEnumMultiSelectField typeField;

        private SearchBooleanField utilizedField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField approved {
            get {
                return this.approvedField;
            }
            set {
                this.approvedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField billable {
            get {
                return this.billableField;
            }
            set {
                this.billableField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
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
        public SearchDateField date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField exempt {
            get {
                return this.exemptField;
            }
            set {
                this.exemptField = value;
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
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastModified {
            get {
                return this.lastModifiedField;
            }
            set {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public SearchStringField memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField paidByPayroll {
            get {
                return this.paidByPayrollField;
            }
            set {
                this.paidByPayrollField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField paidExternally {
            get {
                return this.paidExternallyField;
            }
            set {
                this.paidExternallyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField payItem {
            get {
                return this.payItemField;
            }
            set {
                this.payItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField productive {
            get {
                return this.productiveField;
            }
            set {
                this.productiveField = value;
            }
        }

        /// <remarks/>
        public SearchStringField rejectionNote {
            get {
                return this.rejectionNoteField;
            }
            set {
                this.rejectionNoteField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField status {
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
        public SearchMultiSelectField temporaryLocalJurisdiction {
            get {
                return this.temporaryLocalJurisdictionField;
            }
            set {
                this.temporaryLocalJurisdictionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField temporaryStateJurisdiction {
            get {
                return this.temporaryStateJurisdictionField;
            }
            set {
                this.temporaryStateJurisdictionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField timeModified {
            get {
                return this.timeModifiedField;
            }
            set {
                this.timeModifiedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField timeSheet {
            get {
                return this.timeSheetField;
            }
            set {
                this.timeSheetField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField utilized {
            get {
                return this.utilizedField;
            }
            set {
                this.utilizedField = value;
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