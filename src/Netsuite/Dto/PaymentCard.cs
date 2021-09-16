namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class PaymentCard : Record {

        private string lastFourDigitsField;

        private string issuerIdNumberField;

        private RecordRef entityField;

        private string maskField;

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

        private string cardNumberField;

        private System.DateTime expirationDateField;

        private bool expirationDateFieldSpecified;

        private PaymentCardBrand cardBrandField;

        private bool cardBrandFieldSpecified;

        private PaymentCardType cardTypeField;

        private bool cardTypeFieldSpecified;

        private string nameOnCardField;

        private string streetField;

        private string zipCodeField;

        private System.DateTime validFromDateField;

        private bool validFromDateFieldSpecified;

        private string issueNumberField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string lastFourDigits {
            get {
                return this.lastFourDigitsField;
            }
            set {
                this.lastFourDigitsField = value;
            }
        }

        /// <remarks/>
        public string issuerIdNumber {
            get {
                return this.issuerIdNumberField;
            }
            set {
                this.issuerIdNumberField = value;
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
        public string mask {
            get {
                return this.maskField;
            }
            set {
                this.maskField = value;
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
        public string cardNumber {
            get {
                return this.cardNumberField;
            }
            set {
                this.cardNumberField = value;
            }
        }

        /// <remarks/>
        public System.DateTime expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified {
            get {
                return this.expirationDateFieldSpecified;
            }
            set {
                this.expirationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PaymentCardBrand cardBrand {
            get {
                return this.cardBrandField;
            }
            set {
                this.cardBrandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cardBrandSpecified {
            get {
                return this.cardBrandFieldSpecified;
            }
            set {
                this.cardBrandFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PaymentCardType cardType {
            get {
                return this.cardTypeField;
            }
            set {
                this.cardTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cardTypeSpecified {
            get {
                return this.cardTypeFieldSpecified;
            }
            set {
                this.cardTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string nameOnCard {
            get {
                return this.nameOnCardField;
            }
            set {
                this.nameOnCardField = value;
            }
        }

        /// <remarks/>
        public string street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string zipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime validFromDate {
            get {
                return this.validFromDateField;
            }
            set {
                this.validFromDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validFromDateSpecified {
            get {
                return this.validFromDateFieldSpecified;
            }
            set {
                this.validFromDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string issueNumber {
            get {
                return this.issueNumberField;
            }
            set {
                this.issueNumberField = value;
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