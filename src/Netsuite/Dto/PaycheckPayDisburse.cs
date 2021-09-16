namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayDisburse {

        private string methodField;

        private string bankNameField;

        private string bankAccountDecryptField;

        private string statusNameField;

        private double amountField;

        private bool amountFieldSpecified;

        /// <remarks/>
        public string method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
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
        public string bankAccountDecrypt {
            get {
                return this.bankAccountDecryptField;
            }
            set {
                this.bankAccountDecryptField = value;
            }
        }

        /// <remarks/>
        public string statusName {
            get {
                return this.statusNameField;
            }
            set {
                this.statusNameField = value;
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