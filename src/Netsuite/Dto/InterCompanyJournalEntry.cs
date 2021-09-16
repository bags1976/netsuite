namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:general_2021_1.transactions.webservices.netsuite.com")]
    public partial class InterCompanyJournalEntry : Record {

        private RecordRef postingPeriodField;

        private RecordRef customFormField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private RecordRef currencyField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private string tranIdField;

        private System.DateTime reversalDateField;

        private bool reversalDateFieldSpecified;

        private bool reversalDeferField;

        private bool reversalDeferFieldSpecified;

        private RecordRef parentExpenseAllocField;

        private bool isBookSpecificField;

        private bool isBookSpecificFieldSpecified;

        private RecordRef accountingBookField;

        private string reversalEntryField;

        private RecordRef createdFromField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef subsidiaryField;

        private string memoField;

        private RecordRef toSubsidiaryField;

        private bool approvedField;

        private bool approvedFieldSpecified;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private InterCompanyJournalEntryLineList lineListField;

        private InterCompanyJournalEntryAccountingBookDetailList accountingBookDetailListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

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
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public double exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exchangeRateSpecified {
            get {
                return this.exchangeRateFieldSpecified;
            }
            set {
                this.exchangeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime reversalDate {
            get {
                return this.reversalDateField;
            }
            set {
                this.reversalDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reversalDateSpecified {
            get {
                return this.reversalDateFieldSpecified;
            }
            set {
                this.reversalDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool reversalDefer {
            get {
                return this.reversalDeferField;
            }
            set {
                this.reversalDeferField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reversalDeferSpecified {
            get {
                return this.reversalDeferFieldSpecified;
            }
            set {
                this.reversalDeferFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef parentExpenseAlloc {
            get {
                return this.parentExpenseAllocField;
            }
            set {
                this.parentExpenseAllocField = value;
            }
        }

        /// <remarks/>
        public bool isBookSpecific {
            get {
                return this.isBookSpecificField;
            }
            set {
                this.isBookSpecificField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBookSpecificSpecified {
            get {
                return this.isBookSpecificFieldSpecified;
            }
            set {
                this.isBookSpecificFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        public string reversalEntry {
            get {
                return this.reversalEntryField;
            }
            set {
                this.reversalEntryField = value;
            }
        }

        /// <remarks/>
        public RecordRef createdFrom {
            get {
                return this.createdFromField;
            }
            set {
                this.createdFromField = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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
        public RecordRef toSubsidiary {
            get {
                return this.toSubsidiaryField;
            }
            set {
                this.toSubsidiaryField = value;
            }
        }

        /// <remarks/>
        public bool approved {
            get {
                return this.approvedField;
            }
            set {
                this.approvedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approvedSpecified {
            get {
                return this.approvedFieldSpecified;
            }
            set {
                this.approvedFieldSpecified = value;
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
        public InterCompanyJournalEntryLineList lineList {
            get {
                return this.lineListField;
            }
            set {
                this.lineListField = value;
            }
        }

        /// <remarks/>
        public InterCompanyJournalEntryAccountingBookDetailList accountingBookDetailList {
            get {
                return this.accountingBookDetailListField;
            }
            set {
                this.accountingBookDetailListField = value;
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