namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class AccountLocalizations {

        private RecordRef accountingContextField;

        private string acctNumberField;

        private string acctNameField;

        private string legalNameField;

        private Language localeField;

        private bool localeFieldSpecified;

        /// <remarks/>
        public RecordRef accountingContext {
            get {
                return this.accountingContextField;
            }
            set {
                this.accountingContextField = value;
            }
        }

        /// <remarks/>
        public string acctNumber {
            get {
                return this.acctNumberField;
            }
            set {
                this.acctNumberField = value;
            }
        }

        /// <remarks/>
        public string acctName {
            get {
                return this.acctNameField;
            }
            set {
                this.acctNameField = value;
            }
        }

        /// <remarks/>
        public string legalName {
            get {
                return this.legalNameField;
            }
            set {
                this.legalNameField = value;
            }
        }

        /// <remarks/>
        public Language locale {
            get {
                return this.localeField;
            }
            set {
                this.localeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool localeSpecified {
            get {
                return this.localeFieldSpecified;
            }
            set {
                this.localeFieldSpecified = value;
            }
        }
    }
}