namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class Paycheck : Record {

        private string batchNumberField;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string statusField;

        private RecordRef entityField;

        private string addressField;

        private RecordRef departmentField;

        private RecordRef locationField;

        private RecordRef classField;

        private RecordRef workplaceField;

        private string tranIdField;

        private double userAmountField;

        private bool userAmountFieldSpecified;

        private string memoField;

        private RecordRef accountField;

        private string payFrequencyField;

        private double balanceField;

        private bool balanceFieldSpecified;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private RecordRef postingPeriodField;

        private System.DateTime periodEndingField;

        private bool periodEndingFieldSpecified;

        private PaycheckPayEarnList payEarnListField;

        private PaycheckPayTimeList payTimeListField;

        private PaycheckPayExpList payExpListField;

        private PaycheckPayPtoList payPtoListField;

        private PaycheckPayDeductList payDeductListField;

        private PaycheckPayContribList payContribListField;

        private PaycheckPayTaxList payTaxListField;

        private PaycheckPaySummaryList paySummaryListField;

        private PaycheckPayDisburseList payDisburseListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string batchNumber {
            get {
                return this.batchNumberField;
            }
            set {
                this.batchNumberField = value;
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
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
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
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public RecordRef workplace {
            get {
                return this.workplaceField;
            }
            set {
                this.workplaceField = value;
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
        public double userAmount {
            get {
                return this.userAmountField;
            }
            set {
                this.userAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool userAmountSpecified {
            get {
                return this.userAmountFieldSpecified;
            }
            set {
                this.userAmountFieldSpecified = value;
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
        public RecordRef account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public string payFrequency {
            get {
                return this.payFrequencyField;
            }
            set {
                this.payFrequencyField = value;
            }
        }

        /// <remarks/>
        public double balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balanceSpecified {
            get {
                return this.balanceFieldSpecified;
            }
            set {
                this.balanceFieldSpecified = value;
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
        public RecordRef postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

        /// <remarks/>
        public System.DateTime periodEnding {
            get {
                return this.periodEndingField;
            }
            set {
                this.periodEndingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodEndingSpecified {
            get {
                return this.periodEndingFieldSpecified;
            }
            set {
                this.periodEndingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PaycheckPayEarnList payEarnList {
            get {
                return this.payEarnListField;
            }
            set {
                this.payEarnListField = value;
            }
        }

        /// <remarks/>
        public PaycheckPayTimeList payTimeList {
            get {
                return this.payTimeListField;
            }
            set {
                this.payTimeListField = value;
            }
        }

        /// <remarks/>
        public PaycheckPayExpList payExpList {
            get {
                return this.payExpListField;
            }
            set {
                this.payExpListField = value;
            }
        }

        /// <remarks/>
        public PaycheckPayPtoList payPtoList {
            get {
                return this.payPtoListField;
            }
            set {
                this.payPtoListField = value;
            }
        }

        /// <remarks/>
        public PaycheckPayDeductList payDeductList {
            get {
                return this.payDeductListField;
            }
            set {
                this.payDeductListField = value;
            }
        }

        /// <remarks/>
        public PaycheckPayContribList payContribList {
            get {
                return this.payContribListField;
            }
            set {
                this.payContribListField = value;
            }
        }

        /// <remarks/>
        public PaycheckPayTaxList payTaxList {
            get {
                return this.payTaxListField;
            }
            set {
                this.payTaxListField = value;
            }
        }

        /// <remarks/>
        public PaycheckPaySummaryList paySummaryList {
            get {
                return this.paySummaryListField;
            }
            set {
                this.paySummaryListField = value;
            }
        }

        /// <remarks/>
        public PaycheckPayDisburseList payDisburseList {
            get {
                return this.payDisburseListField;
            }
            set {
                this.payDisburseListField = value;
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