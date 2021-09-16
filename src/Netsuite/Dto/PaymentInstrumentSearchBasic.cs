namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PaymentInstrumentSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField customerField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchEnumMultiSelectField paymentInstrumentTypeField;

        private SearchBooleanField preserveOnFileField;

        /// <remarks/>
        public SearchMultiSelectField customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField paymentInstrumentType {
            get {
                return this.paymentInstrumentTypeField;
            }
            set {
                this.paymentInstrumentTypeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField preserveOnFile {
            get {
                return this.preserveOnFileField;
            }
            set {
                this.preserveOnFileField = value;
            }
        }
    }
}