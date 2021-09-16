namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:general_2021_1.transactions.webservices.netsuite.com")]
    public partial class PeriodEndJournalLine {

        private RecordRef accountField;

        private double debitField;

        private bool debitFieldSpecified;

        private double creditField;

        private bool creditFieldSpecified;

        private string memoField;

        private long lineField;

        private bool lineFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public RecordRef account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public double debit {
            get {
                return this.debitField;
            }
            set {
                this.debitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool debitSpecified {
            get {
                return this.debitFieldSpecified;
            }
            set {
                this.debitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double credit {
            get {
                return this.creditField;
            }
            set {
                this.creditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditSpecified {
            get {
                return this.creditFieldSpecified;
            }
            set {
                this.creditFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}