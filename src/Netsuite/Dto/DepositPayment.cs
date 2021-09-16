namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:bank_2021_1.transactions.webservices.netsuite.com")]
    public partial class DepositPayment {

        private bool depositField;

        private bool depositFieldSpecified;

        private long idField;

        private bool idFieldSpecified;

        private System.DateTime docDateField;

        private bool docDateFieldSpecified;

        private string typeField;

        private string docNumberField;

        private string memoField;

        private RecordRef paymentMethodField;

        private string refNumField;

        private RecordRef entityField;

        private RecordRef currencyField;

        private double transactionAmountField;

        private bool transactionAmountFieldSpecified;

        private double paymentAmountField;

        private bool paymentAmountFieldSpecified;

        private long lineIdField;

        private bool lineIdFieldSpecified;

        /// <remarks/>
        public bool deposit {
            get {
                return this.depositField;
            }
            set {
                this.depositField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositSpecified {
            get {
                return this.depositFieldSpecified;
            }
            set {
                this.depositFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime docDate {
            get {
                return this.docDateField;
            }
            set {
                this.docDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool docDateSpecified {
            get {
                return this.docDateFieldSpecified;
            }
            set {
                this.docDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string docNumber {
            get {
                return this.docNumberField;
            }
            set {
                this.docNumberField = value;
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
        public RecordRef paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
            }
        }

        /// <remarks/>
        public string refNum {
            get {
                return this.refNumField;
            }
            set {
                this.refNumField = value;
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
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public double transactionAmount {
            get {
                return this.transactionAmountField;
            }
            set {
                this.transactionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transactionAmountSpecified {
            get {
                return this.transactionAmountFieldSpecified;
            }
            set {
                this.transactionAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double paymentAmount {
            get {
                return this.paymentAmountField;
            }
            set {
                this.paymentAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentAmountSpecified {
            get {
                return this.paymentAmountFieldSpecified;
            }
            set {
                this.paymentAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long lineId {
            get {
                return this.lineIdField;
            }
            set {
                this.lineIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineIdSpecified {
            get {
                return this.lineIdFieldSpecified;
            }
            set {
                this.lineIdFieldSpecified = value;
            }
        }
    }
}