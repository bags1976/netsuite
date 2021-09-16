namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class VendorBillExpense {

        private long orderDocField;

        private bool orderDocFieldSpecified;

        private long orderLineField;

        private bool orderLineFieldSpecified;

        private long lineField;

        private bool lineFieldSpecified;

        private RecordRef categoryField;

        private RecordRef accountField;

        private double amountField;

        private bool amountFieldSpecified;

        private double taxAmountField;

        private bool taxAmountFieldSpecified;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private string memoField;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private string taxDetailsReferenceField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef customerField;

        private bool isBillableField;

        private bool isBillableFieldSpecified;

        private RecordRef projectTaskField;

        private RecordRef taxCodeField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private double taxRate2Field;

        private bool taxRate2FieldSpecified;

        private RecordRef amortizationSchedField;

        private System.DateTime amortizStartDateField;

        private bool amortizStartDateFieldSpecified;

        private System.DateTime amortizationEndDateField;

        private bool amortizationEndDateFieldSpecified;

        private string amortizationResidualField;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public long orderDoc {
            get {
                return this.orderDocField;
            }
            set {
                this.orderDocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderDocSpecified {
            get {
                return this.orderDocFieldSpecified;
            }
            set {
                this.orderDocFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long orderLine {
            get {
                return this.orderLineField;
            }
            set {
                this.orderLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderLineSpecified {
            get {
                return this.orderLineFieldSpecified;
            }
            set {
                this.orderLineFieldSpecified = value;
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
        public RecordRef category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
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
        public double taxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxAmountSpecified {
            get {
                return this.taxAmountFieldSpecified;
            }
            set {
                this.taxAmountFieldSpecified = value;
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
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
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
        public string taxDetailsReference {
            get {
                return this.taxDetailsReferenceField;
            }
            set {
                this.taxDetailsReferenceField = value;
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
        public RecordRef customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        public RecordRef projectTask {
            get {
                return this.projectTaskField;
            }
            set {
                this.projectTaskField = value;
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
        public double taxRate2 {
            get {
                return this.taxRate2Field;
            }
            set {
                this.taxRate2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRate2Specified {
            get {
                return this.taxRate2FieldSpecified;
            }
            set {
                this.taxRate2FieldSpecified = value;
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