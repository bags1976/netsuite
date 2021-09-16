namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PaymentMethodSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accountField;

        private SearchBooleanField creditCardField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isDebitCardField;

        private SearchBooleanField isInactiveField;

        private SearchStringField nameField;

        /// <remarks/>
        public SearchMultiSelectField account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField creditCard {
            get {
                return this.creditCardField;
            }
            set {
                this.creditCardField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isDebitCard {
            get {
                return this.isDebitCardField;
            }
            set {
                this.isDebitCardField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}