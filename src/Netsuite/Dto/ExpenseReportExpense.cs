namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class ExpenseReportExpense {

        private long lineField;

        private bool lineFieldSpecified;

        private System.DateTime expenseDateField;

        private bool expenseDateFieldSpecified;

        private RecordRef categoryField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private double rateField;

        private bool rateFieldSpecified;

        private double foreignAmountField;

        private bool foreignAmountFieldSpecified;

        private RecordRef currencyField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private double amountField;

        private bool amountFieldSpecified;

        private RecordRef taxCodeField;

        private string memoField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private RecordRef departmentField;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private double taxRate2Field;

        private bool taxRate2FieldSpecified;

        private RecordRef classField;

        private RecordRef customerField;

        private RecordRef locationField;

        private bool isBillableField;

        private bool isBillableFieldSpecified;

        private RecordRef expMediaItemField;

        private bool isNonReimbursableField;

        private bool isNonReimbursableFieldSpecified;

        private bool corporateCreditCardField;

        private bool corporateCreditCardFieldSpecified;

        private bool receiptField;

        private bool receiptFieldSpecified;

        private long refNumberField;

        private bool refNumberFieldSpecified;

        private string taxDetailsReferenceField;

        private RecordRef expenseAccountField;

        private CustomFieldRef[] customFieldListField;

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
        public System.DateTime expenseDate {
            get {
                return this.expenseDateField;
            }
            set {
                this.expenseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expenseDateSpecified {
            get {
                return this.expenseDateFieldSpecified;
            }
            set {
                this.expenseDateFieldSpecified = value;
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
        public double quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
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
        public double foreignAmount {
            get {
                return this.foreignAmountField;
            }
            set {
                this.foreignAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool foreignAmountSpecified {
            get {
                return this.foreignAmountFieldSpecified;
            }
            set {
                this.foreignAmountFieldSpecified = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
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
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public RecordRef expMediaItem {
            get {
                return this.expMediaItemField;
            }
            set {
                this.expMediaItemField = value;
            }
        }

        /// <remarks/>
        public bool isNonReimbursable {
            get {
                return this.isNonReimbursableField;
            }
            set {
                this.isNonReimbursableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNonReimbursableSpecified {
            get {
                return this.isNonReimbursableFieldSpecified;
            }
            set {
                this.isNonReimbursableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool corporateCreditCard {
            get {
                return this.corporateCreditCardField;
            }
            set {
                this.corporateCreditCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool corporateCreditCardSpecified {
            get {
                return this.corporateCreditCardFieldSpecified;
            }
            set {
                this.corporateCreditCardFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool receipt {
            get {
                return this.receiptField;
            }
            set {
                this.receiptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptSpecified {
            get {
                return this.receiptFieldSpecified;
            }
            set {
                this.receiptFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long refNumber {
            get {
                return this.refNumberField;
            }
            set {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refNumberSpecified {
            get {
                return this.refNumberFieldSpecified;
            }
            set {
                this.refNumberFieldSpecified = value;
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
        public RecordRef expenseAccount {
            get {
                return this.expenseAccountField;
            }
            set {
                this.expenseAccountField = value;
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