namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:general_2021_1.transactions.webservices.netsuite.com")]
    public partial class StatisticalJournalEntryLine {

        private RecordRef accountField;

        private long lineField;

        private bool lineFieldSpecified;

        private RecordRef locationField;

        private RecordRef scheduleNumField;

        private double debitField;

        private bool debitFieldSpecified;

        private string memoField;

        private RecordRef entityField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef lineUnitField;

        private string previewDebitField;

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
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public RecordRef scheduleNum {
            get {
                return this.scheduleNumField;
            }
            set {
                this.scheduleNumField = value;
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
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public RecordRef lineUnit {
            get {
                return this.lineUnitField;
            }
            set {
                this.lineUnitField = value;
            }
        }

        /// <remarks/>
        public string previewDebit {
            get {
                return this.previewDebitField;
            }
            set {
                this.previewDebitField = value;
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