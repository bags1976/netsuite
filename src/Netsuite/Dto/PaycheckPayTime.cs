namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayTime {

        private bool applyField;

        private bool applyFieldSpecified;

        private long lineField;

        private bool lineFieldSpecified;

        private long payItemField;

        private bool payItemFieldSpecified;

        private string payItemNameField;

        private System.DateTime ddateField;

        private bool ddateFieldSpecified;

        private string custJobField;

        private string serviceItemField;

        private double countField;

        private bool countFieldSpecified;

        private double rateField;

        private bool rateFieldSpecified;

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
        public long payItem {
            get {
                return this.payItemField;
            }
            set {
                this.payItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool payItemSpecified {
            get {
                return this.payItemFieldSpecified;
            }
            set {
                this.payItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string payItemName {
            get {
                return this.payItemNameField;
            }
            set {
                this.payItemNameField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ddate {
            get {
                return this.ddateField;
            }
            set {
                this.ddateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ddateSpecified {
            get {
                return this.ddateFieldSpecified;
            }
            set {
                this.ddateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string custJob {
            get {
                return this.custJobField;
            }
            set {
                this.custJobField = value;
            }
        }

        /// <remarks/>
        public string serviceItem {
            get {
                return this.serviceItemField;
            }
            set {
                this.serviceItemField = value;
            }
        }

        /// <remarks/>
        public double count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countSpecified {
            get {
                return this.countFieldSpecified;
            }
            set {
                this.countFieldSpecified = value;
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