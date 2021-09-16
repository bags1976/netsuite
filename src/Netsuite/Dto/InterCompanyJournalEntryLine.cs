namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:general_2021_1.transactions.webservices.netsuite.com")]
    public partial class InterCompanyJournalEntryLine {

        private RecordRef lineSubsidiaryField;

        private RecordRef accountField;

        private long lineField;

        private bool lineFieldSpecified;

        private double debitField;

        private bool debitFieldSpecified;

        private double creditField;

        private bool creditFieldSpecified;

        private RecordRef taxCodeField;

        private string memoField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private RecordRef entityField;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private RecordRef scheduleField;

        private RecordRef departmentField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private RecordRef classField;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private RecordRef locationField;

        private RecordRef revenueRecognitionRuleField;

        private bool eliminateField;

        private bool eliminateFieldSpecified;

        private string residualField;

        private RecordRef amortizationSchedField;

        private RecordRef scheduleNumField;

        private System.DateTime amortizStartDateField;

        private bool amortizStartDateFieldSpecified;

        private System.DateTime amortizationEndDateField;

        private bool amortizationEndDateFieldSpecified;

        private string amortizationResidualField;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private RecordRef tax1AcctField;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public RecordRef lineSubsidiary {
            get {
                return this.lineSubsidiaryField;
            }
            set {
                this.lineSubsidiaryField = value;
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
        public RecordRef schedule {
            get {
                return this.scheduleField;
            }
            set {
                this.scheduleField = value;
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
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
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
        public string residual {
            get {
                return this.residualField;
            }
            set {
                this.residualField = value;
            }
        }

        /// <remarks/>
        public RecordRef amortizationSched {
            get {
                return this.amortizationSchedField;
            }
            set {
                this.amortizationSchedField = value;
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
        public System.DateTime amortizStartDate {
            get {
                return this.amortizStartDateField;
            }
            set {
                this.amortizStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amortizStartDateSpecified {
            get {
                return this.amortizStartDateFieldSpecified;
            }
            set {
                this.amortizStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime amortizationEndDate {
            get {
                return this.amortizationEndDateField;
            }
            set {
                this.amortizationEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amortizationEndDateSpecified {
            get {
                return this.amortizationEndDateFieldSpecified;
            }
            set {
                this.amortizationEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string amortizationResidual {
            get {
                return this.amortizationResidualField;
            }
            set {
                this.amortizationResidualField = value;
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