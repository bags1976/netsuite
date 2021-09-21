using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BillingScheduleRecurrence {

        private long recurrenceIdField;

        private bool recurrenceIdFieldSpecified;

        private long countField;

        private bool countFieldSpecified;

        private BillingScheduleRecurrenceRecurrenceUnits unitsField;

        private bool unitsFieldSpecified;

        private bool relativeToPreviousField;

        private bool relativeToPreviousFieldSpecified;

        private System.DateTime recurrenceDateField;

        private bool recurrenceDateFieldSpecified;

        private double amountField;

        private bool amountFieldSpecified;

        private RecordRef paymentTermsField;

        /// <remarks/>
        public long recurrenceId {
            get {
                return this.recurrenceIdField;
            }
            set {
                this.recurrenceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurrenceIdSpecified {
            get {
                return this.recurrenceIdFieldSpecified;
            }
            set {
                this.recurrenceIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long count {
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
        public BillingScheduleRecurrenceRecurrenceUnits units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitsSpecified {
            get {
                return this.unitsFieldSpecified;
            }
            set {
                this.unitsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool relativeToPrevious {
            get {
                return this.relativeToPreviousField;
            }
            set {
                this.relativeToPreviousField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeToPreviousSpecified {
            get {
                return this.relativeToPreviousFieldSpecified;
            }
            set {
                this.relativeToPreviousFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime recurrenceDate {
            get {
                return this.recurrenceDateField;
            }
            set {
                this.recurrenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurrenceDateSpecified {
            get {
                return this.recurrenceDateFieldSpecified;
            }
            set {
                this.recurrenceDateFieldSpecified = value;
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
        public RecordRef paymentTerms {
            get {
                return this.paymentTermsField;
            }
            set {
                this.paymentTermsField = value;
            }
        }
    }
}