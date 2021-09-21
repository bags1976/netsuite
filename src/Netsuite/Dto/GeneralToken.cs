using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class GeneralToken : Record {

        private RecordRef entityField;

        private string maskField;

        private PaymentInstrumentSupportedOperation[] supportedOperationsListField;

        private RecordRef paymentMethodField;

        private string memoField;

        private PaymentInstrumentState stateField;

        private bool stateFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool preserveOnFileField;

        private bool preserveOnFileFieldSpecified;

        private bool isDefaultField;

        private bool isDefaultFieldSpecified;

        private string tokenField;

        private System.DateTime tokenExpirationDateField;

        private bool tokenExpirationDateFieldSpecified;

        private TokenFamily tokenFamilyField;

        private bool tokenFamilyFieldSpecified;

        private string tokenNamespaceField;

        private string internalIdField;

        private string externalIdField;

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
        public string mask {
            get {
                return this.maskField;
            }
            set {
                this.maskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeneralTokenSupportedOperationsList", IsNullable=false)]
        public PaymentInstrumentSupportedOperation[] supportedOperationsList {
            get {
                return this.supportedOperationsListField;
            }
            set {
                this.supportedOperationsListField = value;
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
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public PaymentInstrumentState state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stateSpecified {
            get {
                return this.stateFieldSpecified;
            }
            set {
                this.stateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool preserveOnFile {
            get {
                return this.preserveOnFileField;
            }
            set {
                this.preserveOnFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preserveOnFileSpecified {
            get {
                return this.preserveOnFileFieldSpecified;
            }
            set {
                this.preserveOnFileFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDefaultSpecified {
            get {
                return this.isDefaultFieldSpecified;
            }
            set {
                this.isDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }

        /// <remarks/>
        public System.DateTime tokenExpirationDate {
            get {
                return this.tokenExpirationDateField;
            }
            set {
                this.tokenExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tokenExpirationDateSpecified {
            get {
                return this.tokenExpirationDateFieldSpecified;
            }
            set {
                this.tokenExpirationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TokenFamily tokenFamily {
            get {
                return this.tokenFamilyField;
            }
            set {
                this.tokenFamilyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tokenFamilySpecified {
            get {
                return this.tokenFamilyFieldSpecified;
            }
            set {
                this.tokenFamilyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string tokenNamespace {
            get {
                return this.tokenNamespaceField;
            }
            set {
                this.tokenNamespaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}