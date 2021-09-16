namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPaySummary {

        private string payItemField;

        private string payItemTypeField;

        private double amountField;

        private bool amountFieldSpecified;

        private double ytdAmountField;

        private bool ytdAmountFieldSpecified;

        /// <remarks/>
        public string payItem {
            get {
                return this.payItemField;
            }
            set {
                this.payItemField = value;
            }
        }

        /// <remarks/>
        public string payItemType {
            get {
                return this.payItemTypeField;
            }
            set {
                this.payItemTypeField = value;
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
        public double ytdAmount {
            get {
                return this.ytdAmountField;
            }
            set {
                this.ytdAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ytdAmountSpecified {
            get {
                return this.ytdAmountFieldSpecified;
            }
            set {
                this.ytdAmountFieldSpecified = value;
            }
        }
    }
}