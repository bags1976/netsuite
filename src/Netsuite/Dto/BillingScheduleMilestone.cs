namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BillingScheduleMilestone {

        private long milestoneIdField;

        private bool milestoneIdFieldSpecified;

        private double milestoneAmountField;

        private bool milestoneAmountFieldSpecified;

        private RecordRef milestoneTermsField;

        private RecordRef projectTaskField;

        private System.DateTime milestoneDateField;

        private bool milestoneDateFieldSpecified;

        private bool milestoneCompletedField;

        private bool milestoneCompletedFieldSpecified;

        private System.DateTime milestoneActualCompletionDateField;

        private bool milestoneActualCompletionDateFieldSpecified;

        private string commentsField;

        /// <remarks/>
        public long milestoneId {
            get {
                return this.milestoneIdField;
            }
            set {
                this.milestoneIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool milestoneIdSpecified {
            get {
                return this.milestoneIdFieldSpecified;
            }
            set {
                this.milestoneIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double milestoneAmount {
            get {
                return this.milestoneAmountField;
            }
            set {
                this.milestoneAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool milestoneAmountSpecified {
            get {
                return this.milestoneAmountFieldSpecified;
            }
            set {
                this.milestoneAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef milestoneTerms {
            get {
                return this.milestoneTermsField;
            }
            set {
                this.milestoneTermsField = value;
            }
        }

        /// <remarks/>
        public RecordRef projectTask {
            get {
                return this.projectTaskField;
            }
            set {
                this.projectTaskField = value;
            }
        }

        /// <remarks/>
        public System.DateTime milestoneDate {
            get {
                return this.milestoneDateField;
            }
            set {
                this.milestoneDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool milestoneDateSpecified {
            get {
                return this.milestoneDateFieldSpecified;
            }
            set {
                this.milestoneDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool milestoneCompleted {
            get {
                return this.milestoneCompletedField;
            }
            set {
                this.milestoneCompletedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool milestoneCompletedSpecified {
            get {
                return this.milestoneCompletedFieldSpecified;
            }
            set {
                this.milestoneCompletedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime milestoneActualCompletionDate {
            get {
                return this.milestoneActualCompletionDateField;
            }
            set {
                this.milestoneActualCompletionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool milestoneActualCompletionDateSpecified {
            get {
                return this.milestoneActualCompletionDateFieldSpecified;
            }
            set {
                this.milestoneActualCompletionDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
    }
}