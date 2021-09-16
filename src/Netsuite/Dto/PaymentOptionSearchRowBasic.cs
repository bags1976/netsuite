namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PaymentOptionSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnStringField[] maskField;

        private SearchColumnEnumSelectField[] paymentInstrumentTypeField;

        private SearchColumnSelectField[] paymentMethodField;

        private SearchColumnStringField[] preserveOnFileField;

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