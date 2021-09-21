using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class TimeBill : Record {

        private RecordRef customFormField;

        private RecordRef employeeField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private RecordRef approvalStatusField;

        private RecordRef customerField;

        private RecordRef caseTaskEventField;

        private bool isBillableField;

        private bool isBillableFieldSpecified;

        private RecordRef payrollItemField;

        private bool paidExternallyField;

        private bool paidExternallyFieldSpecified;

        private RecordRef workplaceField;

        private RecordRef itemField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private Duration hoursField;

        private RecordRef priceField;

        private TimeBillTimeType timeTypeField;

        private bool timeTypeFieldSpecified;

        private double rateField;

        private bool rateFieldSpecified;

        private bool overrideRateField;

        private bool overrideRateFieldSpecified;

        private RecordRef temporaryLocalJurisdictionField;

        private RecordRef temporaryStateJurisdictionField;

        private string memoField;

        private string rejectionNoteField;

        private RecordRef subsidiaryField;

        private bool supervisorApprovalField;

        private bool supervisorApprovalFieldSpecified;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef timeSheetField;

        private string statusField;

        private bool timeModifiedField;

        private bool timeModifiedFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public RecordRef employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tranDateSpecified {
            get {
                return this.tranDateFieldSpecified;
            }
            set {
                this.tranDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        public RecordRef customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public RecordRef caseTaskEvent {
            get {
                return this.caseTaskEventField;
            }
            set {
                this.caseTaskEventField = value;
            }
        }

        /// <remarks/>
        public bool isBillable {
            get {
                return this.isBillableField;
            }
            set {
                this.isBillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBillableSpecified {
            get {
                return this.isBillableFieldSpecified;
            }
            set {
                this.isBillableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef payrollItem {
            get {
                return this.payrollItemField;
            }
            set {
                this.payrollItemField = value;
            }
        }

        /// <remarks/>
        public bool paidExternally {
            get {
                return this.paidExternallyField;
            }
            set {
                this.paidExternallyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paidExternallySpecified {
            get {
                return this.paidExternallyFieldSpecified;
            }
            set {
                this.paidExternallyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef workplace {
            get {
                return this.workplaceField;
            }
            set {
                this.workplaceField = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public Duration hours {
            get {
                return this.hoursField;
            }
            set {
                this.hoursField = value;
            }
        }

        /// <remarks/>
        public RecordRef price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public TimeBillTimeType timeType {
            get {
                return this.timeTypeField;
            }
            set {
                this.timeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeTypeSpecified {
            get {
                return this.timeTypeFieldSpecified;
            }
            set {
                this.timeTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool overrideRate {
            get {
                return this.overrideRateField;
            }
            set {
                this.overrideRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideRateSpecified {
            get {
                return this.overrideRateFieldSpecified;
            }
            set {
                this.overrideRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef temporaryLocalJurisdiction {
            get {
                return this.temporaryLocalJurisdictionField;
            }
            set {
                this.temporaryLocalJurisdictionField = value;
            }
        }

        /// <remarks/>
        public RecordRef temporaryStateJurisdiction {
            get {
                return this.temporaryStateJurisdictionField;
            }
            set {
                this.temporaryStateJurisdictionField = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public string rejectionNote {
            get {
                return this.rejectionNoteField;
            }
            set {
                this.rejectionNoteField = value;
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
        public bool supervisorApproval {
            get {
                return this.supervisorApprovalField;
            }
            set {
                this.supervisorApprovalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool supervisorApprovalSpecified {
            get {
                return this.supervisorApprovalFieldSpecified;
            }
            set {
                this.supervisorApprovalFieldSpecified = value;
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
        public RecordRef timeSheet {
            get {
                return this.timeSheetField;
            }
            set {
                this.timeSheetField = value;
            }
        }

        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public bool timeModified {
            get {
                return this.timeModifiedField;
            }
            set {
                this.timeModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeModifiedSpecified {
            get {
                return this.timeModifiedFieldSpecified;
            }
            set {
                this.timeModifiedFieldSpecified = value;
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