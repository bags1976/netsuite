namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayPto {

        private long payItemField;

        private bool payItemFieldSpecified;

        private string payItemNameField;

        private double hoursAccruedField;

        private bool hoursAccruedFieldSpecified;

        private double hoursUsedField;

        private bool hoursUsedFieldSpecified;

        private double hoursBalanceField;

        private bool hoursBalanceFieldSpecified;

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
        public double hoursAccrued {
            get {
                return this.hoursAccruedField;
            }
            set {
                this.hoursAccruedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hoursAccruedSpecified {
            get {
                return this.hoursAccruedFieldSpecified;
            }
            set {
                this.hoursAccruedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double hoursUsed {
            get {
                return this.hoursUsedField;
            }
            set {
                this.hoursUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hoursUsedSpecified {
            get {
                return this.hoursUsedFieldSpecified;
            }
            set {
                this.hoursUsedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double hoursBalance {
            get {
                return this.hoursBalanceField;
            }
            set {
                this.hoursBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hoursBalanceSpecified {
            get {
                return this.hoursBalanceFieldSpecified;
            }
            set {
                this.hoursBalanceFieldSpecified = value;
            }
        }
    }
}