namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:general_2021_1.transactions.webservices.netsuite.com")]
    public partial class JournalEntryLine {

        private RecordRef accountField;

        private long lineField;

        private bool lineFieldSpecified;

        private double debitField;

        private bool debitFieldSpecified;

        private double creditField;

        private bool creditFieldSpecified;

        private RecordRef taxAccountField;

        private RecordRef lineTaxCodeField;

        private double lineTaxRateField;

        private bool lineTaxRateFieldSpecified;

        private double debitTaxField;

        private bool debitTaxFieldSpecified;

        private double creditTaxField;

        private bool creditTaxFieldSpecified;

        private double taxBasisField;

        private bool taxBasisFieldSpecified;

        private double totalAmountField;

        private bool totalAmountFieldSpecified;

        private RecordRef taxCodeField;

        private string memoField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private RecordRef entityField;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef revenueRecognitionRuleField;

        private bool eliminateField;

        private bool eliminateFieldSpecified;

        private RecordRef scheduleField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private string residualField;

        private RecordRef scheduleNumField;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private RecordRef tax1AcctField;

        private CustomFieldRef[] customFieldListField;

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
        public long line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineSpecified {
            get {
                return this.lineFieldSpecified;
            }
            set {
                this.lineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double debit {
            get {
                return this.debitField;
            }
            set {
                this.debitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool debitSpecified {
            get {
                return this.debitFieldSpecified;
            }
            set {
                this.debitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double credit {
            get {
                return this.creditField;
            }
            set {
                this.creditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditSpecified {
            get {
                return this.creditFieldSpecified;
            }
            set {
                this.creditFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef taxAccount {
            get {
                return this.taxAccountField;
            }
            set {
                this.taxAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef lineTaxCode {
            get {
                return this.lineTaxCodeField;
            }
            set {
                this.lineTaxCodeField = value;
            }
        }

        /// <remarks/>
        public double lineTaxRate {
            get {
                return this.lineTaxRateField;
            }
            set {
                this.lineTaxRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineTaxRateSpecified {
            get {
                return this.lineTaxRateFieldSpecified;
            }
            set {
                this.lineTaxRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double debitTax {
            get {
                return this.debitTaxField;
            }
            set {
                this.debitTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool debitTaxSpecified {
            get {
                return this.debitTaxFieldSpecified;
            }
            set {
                this.debitTaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double creditTax {
            get {
                return this.creditTaxField;
            }
            set {
                this.creditTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditTaxSpecified {
            get {
                return this.creditTaxFieldSpecified;
            }
            set {
                this.creditTaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double taxBasis {
            get {
                return this.taxBasisField;
            }
            set {
                this.taxBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxBasisSpecified {
            get {
                return this.taxBasisFieldSpecified;
            }
            set {
                this.taxBasisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double totalAmount {
            get {
                return this.totalAmountField;
            }
            set {
                this.totalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalAmountSpecified {
            get {
                return this.totalAmountFieldSpecified;
            }
            set {
                this.totalAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
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
        public double taxRate1 {
            get {
                return this.taxRate1Field;
            }
            set {
                this.taxRate1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRate1Specified {
            get {
                return this.taxRate1FieldSpecified;
            }
            set {
                this.taxRate1FieldSpecified = value;
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
        public double grossAmt {
            get {
                return this.grossAmtField;
            }
            set {
                this.grossAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossAmtSpecified {
            get {
                return this.grossAmtFieldSpecified;
            }
            set {
                this.grossAmtFieldSpecified = value;
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
        public RecordRef revenueRecognitionRule {
            get {
                return this.revenueRecognitionRuleField;
            }
            set {
                this.revenueRecognitionRuleField = value;
            }
        }

        /// <remarks/>
        public bool eliminate {
            get {
                return this.eliminateField;
            }
            set {
                this.eliminateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eliminateSpecified {
            get {
                return this.eliminateFieldSpecified;
            }
            set {
                this.eliminateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef schedule {
            get {
                return this.scheduleField;
            }
            set {
                this.scheduleField = value;
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
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string residual {
            get {
                return this.residualField;
            }
            set {
                this.residualField = value;
            }
        }

        /// <remarks/>
        public RecordRef scheduleNum {
            get {
                return this.scheduleNumField;
            }
            set {
                this.scheduleNumField = value;
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
        public RecordRef tax1Acct {
            get {
                return this.tax1AcctField;
            }
            set {
                this.tax1AcctField = value;
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
    }
}