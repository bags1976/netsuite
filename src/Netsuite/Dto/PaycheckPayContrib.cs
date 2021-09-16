namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayContrib {

        private RecordRef payItemField;

        private long lineField;

        private bool lineFieldSpecified;

        private double wageBaseField;

        private bool wageBaseFieldSpecified;

        private double amountField;

        private bool amountFieldSpecified;

        private bool manualEntryField;

        private bool manualEntryFieldSpecified;

        /// <remarks/>
        public RecordRef payItem {
            get {
                return this.payItemField;
            }
            set {
                this.payItemField = value;
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
        public double wageBase {
            get {
                return this.wageBaseField;
            }
            set {
                this.wageBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wageBaseSpecified {
            get {
                return this.wageBaseFieldSpecified;
            }
            set {
                this.wageBaseFieldSpecified = value;
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
        public bool manualEntry {
            get {
                return this.manualEntryField;
            }
            set {
                this.manualEntryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manualEntrySpecified {
            get {
                return this.manualEntryFieldSpecified;
            }
            set {
                this.manualEntryFieldSpecified = value;
            }
        }
    }
}