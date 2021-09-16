namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class ExpenseReport : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string statusField;

        private RecordRef customFormField;

        private RecordRef accountField;

        private RecordRef entityField;

        private RecordRef expenseReportCurrencyField;

        private double expenseReportExchangeRateField;

        private bool expenseReportExchangeRateFieldSpecified;

        private RecordRef subsidiaryField;

        private System.DateTime taxPointDateField;

        private bool taxPointDateFieldSpecified;

        private string tranIdField;

        private RecordRef acctCorpCardExpField;

        private RecordRef postingPeriodField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private System.DateTime dueDateField;

        private bool dueDateFieldSpecified;

        private RecordRef approvalStatusField;

        private double totalField;

        private bool totalFieldSpecified;

        private RecordRef nextApproverField;

        private double advanceField;

        private bool advanceFieldSpecified;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private double amountField;

        private bool amountFieldSpecified;

        private string memoField;

        private bool completeField;

        private bool completeFieldSpecified;

        private bool supervisorApprovalField;

        private bool supervisorApprovalFieldSpecified;

        private bool accountingApprovalField;

        private bool accountingApprovalFieldSpecified;

        private bool useMultiCurrencyField;

        private bool useMultiCurrencyFieldSpecified;

        private double tax2AmtField;

        private bool tax2AmtFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private ExpenseReportExpenseList expenseListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private TaxDetailsList taxDetailsListField;

        private RecordRef nexusField;

        private RecordRef subsidiaryTaxRegNumField;

        private bool policyViolatedField;

        private bool policyViolatedFieldSpecified;

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
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public RecordRef account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public RecordRef expenseReportCurrency {
            get {
                return this.expenseReportCurrencyField;
            }
            set {
                this.expenseReportCurrencyField = value;
            }
        }

        /// <remarks/>
        public double expenseReportExchangeRate {
            get {
                return this.expenseReportExchangeRateField;
            }
            set {
                this.expenseReportExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expenseReportExchangeRateSpecified {
            get {
                return this.expenseReportExchangeRateFieldSpecified;
            }
            set {
                this.expenseReportExchangeRateFieldSpecified = value;
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
        public System.DateTime taxPointDate {
            get {
                return this.taxPointDateField;
            }
            set {
                this.taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxPointDateSpecified {
            get {
                return this.taxPointDateFieldSpecified;
            }
            set {
                this.taxPointDateFieldSpecified = value;
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
        public RecordRef acctCorpCardExp {
            get {
                return this.acctCorpCardExpField;
            }
            set {
                this.acctCorpCardExpField = value;
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
        public System.DateTime dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueDateSpecified {
            get {
                return this.dueDateFieldSpecified;
            }
            set {
                this.dueDateFieldSpecified = value;
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
        public double total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalSpecified {
            get {
                return this.totalFieldSpecified;
            }
            set {
                this.totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
            }
        }

        /// <remarks/>
        public double advance {
            get {
                return this.advanceField;
            }
            set {
                this.advanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool advanceSpecified {
            get {
                return this.advanceFieldSpecified;
            }
            set {
                this.advanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double tax1Amt {
            get {
                return this.tax1AmtField;
            }
            set {
                this.tax1AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tax1AmtSpecified {
            get {
                return this.tax1AmtFieldSpecified;
            }
            set {
                this.tax1AmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
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
        public bool complete {
            get {
                return this.completeField;
            }
            set {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified {
            get {
                return this.completeFieldSpecified;
            }
            set {
                this.completeFieldSpecified = value;
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
        public bool accountingApproval {
            get {
                return this.accountingApprovalField;
            }
            set {
                this.accountingApprovalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accountingApprovalSpecified {
            get {
                return this.accountingApprovalFieldSpecified;
            }
            set {
                this.accountingApprovalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool useMultiCurrency {
            get {
                return this.useMultiCurrencyField;
            }
            set {
                this.useMultiCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useMultiCurrencySpecified {
            get {
                return this.useMultiCurrencyFieldSpecified;
            }
            set {
                this.useMultiCurrencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double tax2Amt {
            get {
                return this.tax2AmtField;
            }
            set {
                this.tax2AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tax2AmtSpecified {
            get {
                return this.tax2AmtFieldSpecified;
            }
            set {
                this.tax2AmtFieldSpecified = value;
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
        public ExpenseReportExpenseList expenseList {
            get {
                return this.expenseListField;
            }
            set {
                this.expenseListField = value;
            }
        }

        /// <remarks/>
        public AccountingBookDetailList accountingBookDetailList {
            get {
                return this.accountingBookDetailListField;
            }
            set {
                this.accountingBookDetailListField = value;
            }
        }

        /// <remarks/>
        public TaxDetailsList taxDetailsList {
            get {
                return this.taxDetailsListField;
            }
            set {
                this.taxDetailsListField = value;
            }
        }

        /// <remarks/>
        public RecordRef nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiaryTaxRegNum {
            get {
                return this.subsidiaryTaxRegNumField;
            }
            set {
                this.subsidiaryTaxRegNumField = value;
            }
        }

        /// <remarks/>
        public bool policyViolated {
            get {
                return this.policyViolatedField;
            }
            set {
                this.policyViolatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool policyViolatedSpecified {
            get {
                return this.policyViolatedFieldSpecified;
            }
            set {
                this.policyViolatedFieldSpecified = value;
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