namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class JobCreditCards {

        private string internalIdField;

        private string ccNumberField;

        private System.DateTime ccExpireDateField;

        private bool ccExpireDateFieldSpecified;

        private string ccNameField;

        private RecordRef paymentMethodField;

        private string ccMemoField;

        private bool ccDefaultField;

        private bool ccDefaultFieldSpecified;

        private string debitCardIssueNoField;

        private System.DateTime validFromField;

        private bool validFromFieldSpecified;

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
        public string ccMemo {
            get {
                return this.ccMemoField;
            }
            set {
                this.ccMemoField = value;
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

        /// <remarks/>
        public string debitCardIssueNo {
            get {
                return this.debitCardIssueNoField;
            }
            set {
                this.debitCardIssueNoField = value;
            }
        }

        /// <remarks/>
        public System.DateTime validFrom {
            get {
                return this.validFromField;
            }
            set {
                this.validFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validFromSpecified {
            get {
                return this.validFromFieldSpecified;
            }
            set {
                this.validFromFieldSpecified = value;
            }
        }
    }
}