namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:general_2021_1.transactions.webservices.netsuite.com")]
    public partial class PeriodEndJournal : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string transactionNumberField;

        private RecordRef accountingBookField;

        private RecordRef customFormField;

        private string tranIdField;

        private System.DateTime trandateField;

        private bool trandateFieldSpecified;

        private RecordRef postingPeriodField;

        private string memoField;

        private RecordRef subsidiaryField;

        private RecordRef sourceSubsidiaryField;

        private RecordRef classField;

        private RecordRef departmentField;

        private RecordRef locationField;

        private RecordRef mainAccountField;

        private RecordRef currencyField;

        private double creditTotalField;

        private bool creditTotalFieldSpecified;

        private double debitTotalField;

        private bool debitTotalFieldSpecified;

        private PeriodEndJournalLineList lineListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public string transactionNumber {
            get {
                return this.transactionNumberField;
            }
            set {
                this.transactionNumberField = value;
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
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
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
        public System.DateTime trandate {
            get {
                return this.trandateField;
            }
            set {
                this.trandateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trandateSpecified {
            get {
                return this.trandateFieldSpecified;
            }
            set {
                this.trandateFieldSpecified = value;
            }
        }

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
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
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
        public RecordRef sourceSubsidiary {
            get {
                return this.sourceSubsidiaryField;
            }
            set {
                this.sourceSubsidiaryField = value;
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
        public RecordRef mainAccount {
            get {
                return this.mainAccountField;
            }
            set {
                this.mainAccountField = value;
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
        public double creditTotal {
            get {
                return this.creditTotalField;
            }
            set {
                this.creditTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditTotalSpecified {
            get {
                return this.creditTotalFieldSpecified;
            }
            set {
                this.creditTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double debitTotal {
            get {
                return this.debitTotalField;
            }
            set {
                this.debitTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool debitTotalSpecified {
            get {
                return this.debitTotalFieldSpecified;
            }
            set {
                this.debitTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PeriodEndJournalLineList lineList {
            get {
                return this.lineListField;
            }
            set {
                this.lineListField = value;
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