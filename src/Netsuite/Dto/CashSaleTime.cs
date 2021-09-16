namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class CashSaleTime {

        private bool applyField;

        private bool applyFieldSpecified;

        private long docField;

        private bool docFieldSpecified;

        private long lineField;

        private bool lineFieldSpecified;

        private System.DateTime billedDateField;

        private bool billedDateFieldSpecified;

        private string employeeDispField;

        private string itemDispField;

        private string jobDispField;

        private string departmentField;

        private string classField;

        private string locationField;

        private string quantityField;

        private double rateField;

        private bool rateFieldSpecified;

        private string unitDispField;

        private double amountField;

        private bool amountFieldSpecified;

        private string memoField;

        private double taxAmountField;

        private bool taxAmountFieldSpecified;

        private RecordRef revRecScheduleField;

        private System.DateTime revRecStartDateField;

        private bool revRecStartDateFieldSpecified;

        private System.DateTime revRecEndDateField;

        private bool revRecEndDateFieldSpecified;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private string taxDetailsReferenceField;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private RecordRef taxCodeField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private double taxRate2Field;

        private bool taxRate2FieldSpecified;

        /// <remarks/>
        public bool apply {
            get {
                return this.applyField;
            }
            set {
                this.applyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applySpecified {
            get {
                return this.applyFieldSpecified;
            }
            set {
                this.applyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long doc {
            get {
                return this.docField;
            }
            set {
                this.docField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool docSpecified {
            get {
                return this.docFieldSpecified;
            }
            set {
                this.docFieldSpecified = value;
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
        public System.DateTime billedDate {
            get {
                return this.billedDateField;
            }
            set {
                this.billedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billedDateSpecified {
            get {
                return this.billedDateFieldSpecified;
            }
            set {
                this.billedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string employeeDisp {
            get {
                return this.employeeDispField;
            }
            set {
                this.employeeDispField = value;
            }
        }

        /// <remarks/>
        public string itemDisp {
            get {
                return this.itemDispField;
            }
            set {
                this.itemDispField = value;
            }
        }

        /// <remarks/>
        public string jobDisp {
            get {
                return this.jobDispField;
            }
            set {
                this.jobDispField = value;
            }
        }

        /// <remarks/>
        public string department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public string @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public string location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public string quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
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
        public string unitDisp {
            get {
                return this.unitDispField;
            }
            set {
                this.unitDispField = value;
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
        public RecordRef revRecSchedule {
            get {
                return this.revRecScheduleField;
            }
            set {
                this.revRecScheduleField = value;
            }
        }

        /// <remarks/>
        public System.DateTime revRecStartDate {
            get {
                return this.revRecStartDateField;
            }
            set {
                this.revRecStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revRecStartDateSpecified {
            get {
                return this.revRecStartDateFieldSpecified;
            }
            set {
                this.revRecStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime revRecEndDate {
            get {
                return this.revRecEndDateField;
            }
            set {
                this.revRecEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revRecEndDateSpecified {
            get {
                return this.revRecEndDateFieldSpecified;
            }
            set {
                this.revRecEndDateFieldSpecified = value;
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
    }
}