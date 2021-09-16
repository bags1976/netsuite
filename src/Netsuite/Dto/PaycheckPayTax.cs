namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayTax {

        private long lineField;

        private bool lineFieldSpecified;

        private bool applyField;

        private bool applyFieldSpecified;

        private string payTaxField;

        private long payItemField;

        private bool payItemFieldSpecified;

        private double taxableWageBaseField;

        private bool taxableWageBaseFieldSpecified;

        private double taxedWageBaseField;

        private bool taxedWageBaseFieldSpecified;

        private double reportableWageBaseField;

        private bool reportableWageBaseFieldSpecified;

        private bool isExemptField;

        private bool isExemptFieldSpecified;

        private bool isResidentTaxField;

        private bool isResidentTaxFieldSpecified;

        private double amountField;

        private bool amountFieldSpecified;

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
        public string payTax {
            get {
                return this.payTaxField;
            }
            set {
                this.payTaxField = value;
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
        public double taxableWageBase {
            get {
                return this.taxableWageBaseField;
            }
            set {
                this.taxableWageBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxableWageBaseSpecified {
            get {
                return this.taxableWageBaseFieldSpecified;
            }
            set {
                this.taxableWageBaseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double taxedWageBase {
            get {
                return this.taxedWageBaseField;
            }
            set {
                this.taxedWageBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxedWageBaseSpecified {
            get {
                return this.taxedWageBaseFieldSpecified;
            }
            set {
                this.taxedWageBaseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double reportableWageBase {
            get {
                return this.reportableWageBaseField;
            }
            set {
                this.reportableWageBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reportableWageBaseSpecified {
            get {
                return this.reportableWageBaseFieldSpecified;
            }
            set {
                this.reportableWageBaseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isExempt {
            get {
                return this.isExemptField;
            }
            set {
                this.isExemptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isExemptSpecified {
            get {
                return this.isExemptFieldSpecified;
            }
            set {
                this.isExemptFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isResidentTax {
            get {
                return this.isResidentTaxField;
            }
            set {
                this.isResidentTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isResidentTaxSpecified {
            get {
                return this.isResidentTaxFieldSpecified;
            }
            set {
                this.isResidentTaxFieldSpecified = value;
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