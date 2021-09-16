namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayExp {

        private bool applyField;

        private bool applyFieldSpecified;

        private long lineField;

        private bool lineFieldSpecified;

        private long origDocField;

        private bool origDocFieldSpecified;

        private string transactionField;

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
        public long origDoc {
            get {
                return this.origDocField;
            }
            set {
                this.origDocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool origDocSpecified {
            get {
                return this.origDocFieldSpecified;
            }
            set {
                this.origDocFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string transaction {
            get {
                return this.transactionField;
            }
            set {
                this.transactionField = value;
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