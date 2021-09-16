namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PaymentInstrumentSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] cardBrandField;

        private SearchColumnDateField[] cardExpDateField;

        private SearchColumnStringField[] cardLastFourDigitsField;

        private SearchColumnStringField[] cardTokenCardBrandField;

        private SearchColumnDateField[] cardTokenCardExpDateField;

        private SearchColumnDateField[] cardTokenExpDateField;

        private SearchColumnStringField[] cardTokenNameOnCardField;

        private SearchColumnStringField[] defaultField;

        private SearchColumnSelectField[] entityField;

        private SearchColumnDateField[] generalTokenExpirationDateField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnStringField[] isInactiveField;

        private SearchColumnStringField[] lastFourDigitsField;

        private SearchColumnStringField[] maskField;

        private SearchColumnStringField[] nameOnCardField;

        private SearchColumnSelectField[] paymentInstrumentStateTypeField;

        private SearchColumnEnumSelectField[] paymentInstrumentTypeField;

        private SearchColumnSelectField[] paymentMethodField;

        private SearchColumnStringField[] preserveOnFileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cardBrand")]
        public SearchColumnStringField[] cardBrand {
            get {
                return this.cardBrandField;
            }
            set {
                this.cardBrandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cardExpDate")]
        public SearchColumnDateField[] cardExpDate {
            get {
                return this.cardExpDateField;
            }
            set {
                this.cardExpDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cardLastFourDigits")]
        public SearchColumnStringField[] cardLastFourDigits {
            get {
                return this.cardLastFourDigitsField;
            }
            set {
                this.cardLastFourDigitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cardTokenCardBrand")]
        public SearchColumnStringField[] cardTokenCardBrand {
            get {
                return this.cardTokenCardBrandField;
            }
            set {
                this.cardTokenCardBrandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cardTokenCardExpDate")]
        public SearchColumnDateField[] cardTokenCardExpDate {
            get {
                return this.cardTokenCardExpDateField;
            }
            set {
                this.cardTokenCardExpDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cardTokenExpDate")]
        public SearchColumnDateField[] cardTokenExpDate {
            get {
                return this.cardTokenExpDateField;
            }
            set {
                this.cardTokenExpDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cardTokenNameOnCard")]
        public SearchColumnStringField[] cardTokenNameOnCard {
            get {
                return this.cardTokenNameOnCardField;
            }
            set {
                this.cardTokenNameOnCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("default")]
        public SearchColumnStringField[] @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entity")]
        public SearchColumnSelectField[] entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("generalTokenExpirationDate")]
        public SearchColumnDateField[] generalTokenExpirationDate {
            get {
                return this.generalTokenExpirationDateField;
            }
            set {
                this.generalTokenExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnStringField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastFourDigits")]
        public SearchColumnStringField[] lastFourDigits {
            get {
                return this.lastFourDigitsField;
            }
            set {
                this.lastFourDigitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mask")]
        public SearchColumnStringField[] mask {
            get {
                return this.maskField;
            }
            set {
                this.maskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nameOnCard")]
        public SearchColumnStringField[] nameOnCard {
            get {
                return this.nameOnCardField;
            }
            set {
                this.nameOnCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentInstrumentStateType")]
        public SearchColumnSelectField[] paymentInstrumentStateType {
            get {
                return this.paymentInstrumentStateTypeField;
            }
            set {
                this.paymentInstrumentStateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentInstrumentType")]
        public SearchColumnEnumSelectField[] paymentInstrumentType {
            get {
                return this.paymentInstrumentTypeField;
            }
            set {
                this.paymentInstrumentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentMethod")]
        public SearchColumnSelectField[] paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("preserveOnFile")]
        public SearchColumnStringField[] preserveOnFile {
            get {
                return this.preserveOnFileField;
            }
            set {
                this.preserveOnFileField = value;
            }
        }
    }
}