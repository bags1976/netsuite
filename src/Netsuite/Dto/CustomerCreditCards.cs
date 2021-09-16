namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class CustomerCreditCards {

        private string internalIdField;

        private string ccNumberField;

        private System.DateTime ccExpireDateField;

        private bool ccExpireDateFieldSpecified;

        private string ccNameField;

        private RecordRef paymentMethodField;

        private RecordRef cardStateField;

        private System.DateTime stateFromField;

        private bool stateFromFieldSpecified;

        private string debitcardIssueNoField;

        private string ccMemoField;

        private System.DateTime validfromField;

        private bool validfromFieldSpecified;

        private bool ccDefaultField;

        private bool ccDefaultFieldSpecified;

        /// <remarks/>
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public string ccNumber {
            get {
                return this.ccNumberField;
            }
            set {
                this.ccNumberField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ccExpireDate {
            get {
                return this.ccExpireDateField;
            }
            set {
                this.ccExpireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccExpireDateSpecified {
            get {
                return this.ccExpireDateFieldSpecified;
            }
            set {
                this.ccExpireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ccName {
            get {
                return this.ccNameField;
            }
            set {
                this.ccNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
            }
        }

        /// <remarks/>
        public RecordRef cardState {
            get {
                return this.cardStateField;
            }
            set {
                this.cardStateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime stateFrom {
            get {
                return this.stateFromField;
            }
            set {
                this.stateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stateFromSpecified {
            get {
                return this.stateFromFieldSpecified;
            }
            set {
                this.stateFromFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string debitcardIssueNo {
            get {
                return this.debitcardIssueNoField;
            }
            set {
                this.debitcardIssueNoField = value;
            }
        }

        /// <remarks/>
        public string ccMemo {
            get {
                return this.ccMemoField;
            }
            set {
                this.ccMemoField = value;
            }
        }

        /// <remarks/>
        public System.DateTime validfrom {
            get {
                return this.validfromField;
            }
            set {
                this.validfromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validfromSpecified {
            get {
                return this.validfromFieldSpecified;
            }
            set {
                this.validfromFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ccDefault {
            get {
                return this.ccDefaultField;
            }
            set {
                this.ccDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccDefaultSpecified {
            get {
                return this.ccDefaultFieldSpecified;
            }
            set {
                this.ccDefaultFieldSpecified = value;
            }
        }
    }
}