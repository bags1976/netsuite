namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class BillingAccount : Record {

        private RecordRef customFormField;

        private string idNumberField;

        private bool customerDefaultField;

        private bool customerDefaultFieldSpecified;

        private RecordRef customerField;

        private RecordRef subsidiaryField;

        private string nameField;

        private bool inactiveField;

        private bool inactiveFieldSpecified;

        private string memoField;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private string createdByField;

        private RecordRef currencyField;

        private RecordRef classField;

        private RecordRef departmentField;

        private RecordRef locationField;

        private RecordRef billingScheduleField;

        private BillingAccountFrequency frequencyField;

        private bool frequencyFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime lastBillDateField;

        private bool lastBillDateFieldSpecified;

        private System.DateTime lastBillCycleDateField;

        private bool lastBillCycleDateFieldSpecified;

        private System.DateTime nextBillCycleDateField;

        private bool nextBillCycleDateFieldSpecified;

        private RecordRef invoiceFormField;

        private RecordRef cashSaleFormField;

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
        public string idNumber {
            get {
                return this.idNumberField;
            }
            set {
                this.idNumberField = value;
            }
        }

        /// <remarks/>
        public bool customerDefault {
            get {
                return this.customerDefaultField;
            }
            set {
                this.customerDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool customerDefaultSpecified {
            get {
                return this.customerDefaultFieldSpecified;
            }
            set {
                this.customerDefaultFieldSpecified = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public bool inactive {
            get {
                return this.inactiveField;
            }
            set {
                this.inactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inactiveSpecified {
            get {
                return this.inactiveFieldSpecified;
            }
            set {
                this.inactiveFieldSpecified = value;
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
        public string createdBy {
            get {
                return this.createdByField;
            }
            set {
                this.createdByField = value;
            }
        }

        /// <remarks/>
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public RecordRef billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
            }
        }

        /// <remarks/>
        public BillingAccountFrequency frequency {
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
        public System.DateTime lastBillDate {
            get {
                return this.lastBillDateField;
            }
            set {
                this.lastBillDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastBillDateSpecified {
            get {
                return this.lastBillDateFieldSpecified;
            }
            set {
                this.lastBillDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastBillCycleDate {
            get {
                return this.lastBillCycleDateField;
            }
            set {
                this.lastBillCycleDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastBillCycleDateSpecified {
            get {
                return this.lastBillCycleDateFieldSpecified;
            }
            set {
                this.lastBillCycleDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime nextBillCycleDate {
            get {
                return this.nextBillCycleDateField;
            }
            set {
                this.nextBillCycleDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nextBillCycleDateSpecified {
            get {
                return this.nextBillCycleDateFieldSpecified;
            }
            set {
                this.nextBillCycleDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef invoiceForm {
            get {
                return this.invoiceFormField;
            }
            set {
                this.invoiceFormField = value;
            }
        }

        /// <remarks/>
        public RecordRef cashSaleForm {
            get {
                return this.cashSaleFormField;
            }
            set {
                this.cashSaleFormField = value;
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