namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class VendorPaymentApply {

        private bool applyField;

        private bool applyFieldSpecified;

        private long docField;

        private bool docFieldSpecified;

        private long lineField;

        private bool lineFieldSpecified;

        private string jobField;

        private System.DateTime applyDateField;

        private bool applyDateFieldSpecified;

        private string typeField;

        private string refNumField;

        private double totalField;

        private bool totalFieldSpecified;

        private double dueField;

        private bool dueFieldSpecified;

        private string currencyField;

        private System.DateTime discDateField;

        private bool discDateFieldSpecified;

        private double discAmtField;

        private bool discAmtFieldSpecified;

        private double discField;

        private bool discFieldSpecified;

        private double amountField;

        private bool amountFieldSpecified;

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
        public string job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }

        /// <remarks/>
        public System.DateTime applyDate {
            get {
                return this.applyDateField;
            }
            set {
                this.applyDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyDateSpecified {
            get {
                return this.applyDateFieldSpecified;
            }
            set {
                this.applyDateFieldSpecified = value;
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
        public string refNum {
            get {
                return this.refNumField;
            }
            set {
                this.refNumField = value;
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
        public double due {
            get {
                return this.dueField;
            }
            set {
                this.dueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueSpecified {
            get {
                return this.dueFieldSpecified;
            }
            set {
                this.dueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public System.DateTime discDate {
            get {
                return this.discDateField;
            }
            set {
                this.discDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discDateSpecified {
            get {
                return this.discDateFieldSpecified;
            }
            set {
                this.discDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double discAmt {
            get {
                return this.discAmtField;
            }
            set {
                this.discAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discAmtSpecified {
            get {
                return this.discAmtFieldSpecified;
            }
            set {
                this.discAmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double disc {
            get {
                return this.discField;
            }
            set {
                this.discField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discSpecified {
            get {
                return this.discFieldSpecified;
            }
            set {
                this.discFieldSpecified = value;
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
    }
}