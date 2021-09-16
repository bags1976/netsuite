namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TimeEntrySearchBasic : SearchRecordBasic {

        private SearchMultiSelectField approvalStatusField;

        private SearchBooleanField billableField;

        private SearchMultiSelectField billingClassField;

        private SearchBooleanField billingStatusField;

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

        private SearchBooleanField isChargedField;

        private SearchMultiSelectField itemField;

        private SearchDateField lastModifiedField;

        private SearchMultiSelectField locationField;

        private SearchStringField memoField;

        private SearchMultiSelectField nextApproverField;

        private SearchBooleanField paidByPayrollField;

        private SearchBooleanField paidExternallyField;

        private SearchMultiSelectField payItemField;

        private SearchBooleanField productiveField;

        private SearchMultiSelectField subsidiaryField;

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
        public SearchBooleanField billable {
            get {
                return this.billableField;
            }
            set {
                this.billableField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billingClass {
            get {
                return this.billingClassField;
            }
            set {
                this.billingClassField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField billingStatus {
            get {
                return this.billingStatusField;
            }
            set {
                this.billingStatusField = value;
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
        public SearchBooleanField isCharged {
            get {
                return this.isChargedField;
            }
            set {
                this.isChargedField = value;
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
        public SearchMultiSelectField nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
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
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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