namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayEarn {

        private RecordRef payItemField;

        private long lineField;

        private bool lineFieldSpecified;

        private double countField;

        private bool countFieldSpecified;

        private string rateField;

        private RecordRef serviceItemField;

        private double grossAmountField;

        private bool grossAmountFieldSpecified;

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
        public string rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public RecordRef serviceItem {
            get {
                return this.serviceItemField;
            }
            set {
                this.serviceItemField = value;
            }
        }

        /// <remarks/>
        public double grossAmount {
            get {
                return this.grossAmountField;
            }
            set {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossAmountSpecified {
            get {
                return this.grossAmountFieldSpecified;
            }
            set {
                this.grossAmountFieldSpecified = value;
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