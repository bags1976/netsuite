namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class Installment {

        private double amountField;

        private bool amountFieldSpecified;

        private System.DateTime dueDateField;

        private bool dueDateFieldSpecified;

        private double amountDueField;

        private bool amountDueFieldSpecified;

        private long seqNumField;

        private bool seqNumFieldSpecified;

        private string statusField;

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
        public System.DateTime dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueDateSpecified {
            get {
                return this.dueDateFieldSpecified;
            }
            set {
                this.dueDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double amountDue {
            get {
                return this.amountDueField;
            }
            set {
                this.amountDueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountDueSpecified {
            get {
                return this.amountDueFieldSpecified;
            }
            set {
                this.amountDueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long seqNum {
            get {
                return this.seqNumField;
            }
            set {
                this.seqNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool seqNumSpecified {
            get {
                return this.seqNumFieldSpecified;
            }
            set {
                this.seqNumFieldSpecified = value;
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
    }
}