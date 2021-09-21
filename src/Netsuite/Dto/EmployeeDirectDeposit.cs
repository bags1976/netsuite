using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeDirectDeposit {

        private long idField;

        private bool idFieldSpecified;

        private bool netAccountField;

        private bool netAccountFieldSpecified;

        private bool savingsAccountField;

        private bool savingsAccountFieldSpecified;

        private bool accountPrenotedField;

        private bool accountPrenotedFieldSpecified;

        private EmployeeDirectDepositAccountStatus accountStatusField;

        private bool accountStatusFieldSpecified;

        private string bankNameField;

        private string bankIdField;

        private string bankNumberField;

        private string bankRoutingNumberField;

        private string bankAccountNumberField;

        private double amountField;

        private bool amountFieldSpecified;

        private bool inactiveField;

        private bool inactiveFieldSpecified;

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
        public bool netAccount {
            get {
                return this.netAccountField;
            }
            set {
                this.netAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool netAccountSpecified {
            get {
                return this.netAccountFieldSpecified;
            }
            set {
                this.netAccountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool savingsAccount {
            get {
                return this.savingsAccountField;
            }
            set {
                this.savingsAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool savingsAccountSpecified {
            get {
                return this.savingsAccountFieldSpecified;
            }
            set {
                this.savingsAccountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool accountPrenoted {
            get {
                return this.accountPrenotedField;
            }
            set {
                this.accountPrenotedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accountPrenotedSpecified {
            get {
                return this.accountPrenotedFieldSpecified;
            }
            set {
                this.accountPrenotedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmployeeDirectDepositAccountStatus accountStatus {
            get {
                return this.accountStatusField;
            }
            set {
                this.accountStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accountStatusSpecified {
            get {
                return this.accountStatusFieldSpecified;
            }
            set {
                this.accountStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string bankName {
            get {
                return this.bankNameField;
            }
            set {
                this.bankNameField = value;
            }
        }

        /// <remarks/>
        public string bankId {
            get {
                return this.bankIdField;
            }
            set {
                this.bankIdField = value;
            }
        }

        /// <remarks/>
        public string bankNumber {
            get {
                return this.bankNumberField;
            }
            set {
                this.bankNumberField = value;
            }
        }

        /// <remarks/>
        public string bankRoutingNumber {
            get {
                return this.bankRoutingNumberField;
            }
            set {
                this.bankRoutingNumberField = value;
            }
        }

        /// <remarks/>
        public string bankAccountNumber {
            get {
                return this.bankAccountNumberField;
            }
            set {
                this.bankAccountNumberField = value;
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
        public bool inactive {
            get {
                return this.inactiveField;
            }
            set {
                this.inactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inactiveSpecified {
            get {
                return this.inactiveFieldSpecified;
            }
            set {
                this.inactiveFieldSpecified = value;
            }
        }
    }
}