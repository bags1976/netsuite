namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TimeBillSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] approvalStatusField;

        private SearchColumnStringField[] breakField;

        private SearchColumnSelectField[] classField;

        private SearchColumnSelectField[] customerField;

        private SearchColumnDateField[] dateField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnSelectField[] departmentField;

        private SearchColumnDoubleField[] durationDecimalField;

        private SearchColumnSelectField[] employeeField;

        private SearchColumnDateField[] endTimeField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] hoursField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isBillableField;

        private SearchColumnBooleanField[] isExemptField;

        private SearchColumnBooleanField[] isProductiveField;

        private SearchColumnBooleanField[] isUtilizedField;

        private SearchColumnStringField[] itemField;

        private SearchColumnDateField[] lastModifiedField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnStringField[] memoField;

        private SearchColumnBooleanField[] paidExternallyField;

        private SearchColumnSelectField[] payItemField;

        private SearchColumnDateField[] payrollDateField;

        private SearchColumnDoubleField[] rateField;

        private SearchColumnStringField[] rejectionNoteField;

        private SearchColumnDateField[] startTimeField;

        private SearchColumnStringField[] statusField;

        private SearchColumnStringField[] subsidiaryField;

        private SearchColumnBooleanField[] supervisorApprovalField;

        private SearchColumnStringField[] temporaryLocalJurisdictionField;

        private SearchColumnStringField[] temporaryStateJurisdictionField;

        private SearchColumnBooleanField[] timeModifiedField;

        private SearchColumnSelectField[] timeSheetField;

        private SearchColumnEnumSelectField[] typeField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("approvalStatus")]
        public SearchColumnSelectField[] approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("break")]
        public SearchColumnStringField[] @break {
            get {
                return this.breakField;
            }
            set {
                this.breakField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("class")]
        public SearchColumnSelectField[] @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customer")]
        public SearchColumnSelectField[] customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("date")]
        public SearchColumnDateField[] date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateCreated")]
        public SearchColumnDateField[] dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("department")]
        public SearchColumnSelectField[] department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("durationDecimal")]
        public SearchColumnDoubleField[] durationDecimal {
            get {
                return this.durationDecimalField;
            }
            set {
                this.durationDecimalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employee")]
        public SearchColumnSelectField[] employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endTime")]
        public SearchColumnDateField[] endTime {
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
        [System.Xml.Serialization.XmlElementAttribute("hours")]
        public SearchColumnStringField[] hours {
            get {
                return this.hoursField;
            }
            set {
                this.hoursField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isBillable")]
        public SearchColumnBooleanField[] isBillable {
            get {
                return this.isBillableField;
            }
            set {
                this.isBillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isExempt")]
        public SearchColumnBooleanField[] isExempt {
            get {
                return this.isExemptField;
            }
            set {
                this.isExemptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isProductive")]
        public SearchColumnBooleanField[] isProductive {
            get {
                return this.isProductiveField;
            }
            set {
                this.isProductiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isUtilized")]
        public SearchColumnBooleanField[] isUtilized {
            get {
                return this.isUtilizedField;
            }
            set {
                this.isUtilizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnStringField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModified")]
        public SearchColumnDateField[] lastModified {
            get {
                return this.lastModifiedField;
            }
            set {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paidExternally")]
        public SearchColumnBooleanField[] paidExternally {
            get {
                return this.paidExternallyField;
            }
            set {
                this.paidExternallyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payItem")]
        public SearchColumnSelectField[] payItem {
            get {
                return this.payItemField;
            }
            set {
                this.payItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payrollDate")]
        public SearchColumnDateField[] payrollDate {
            get {
                return this.payrollDateField;
            }
            set {
                this.payrollDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rate")]
        public SearchColumnDoubleField[] rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rejectionNote")]
        public SearchColumnStringField[] rejectionNote {
            get {
                return this.rejectionNoteField;
            }
            set {
                this.rejectionNoteField = value;
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
        public SearchColumnStringField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnStringField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("supervisorApproval")]
        public SearchColumnBooleanField[] supervisorApproval {
            get {
                return this.supervisorApprovalField;
            }
            set {
                this.supervisorApprovalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("temporaryLocalJurisdiction")]
        public SearchColumnStringField[] temporaryLocalJurisdiction {
            get {
                return this.temporaryLocalJurisdictionField;
            }
            set {
                this.temporaryLocalJurisdictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("temporaryStateJurisdiction")]
        public SearchColumnStringField[] temporaryStateJurisdiction {
            get {
                return this.temporaryStateJurisdictionField;
            }
            set {
                this.temporaryStateJurisdictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timeModified")]
        public SearchColumnBooleanField[] timeModified {
            get {
                return this.timeModifiedField;
            }
            set {
                this.timeModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timeSheet")]
        public SearchColumnSelectField[] timeSheet {
            get {
                return this.timeSheetField;
            }
            set {
                this.timeSheetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("type")]
        public SearchColumnEnumSelectField[] type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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