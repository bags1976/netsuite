namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CouponCodeSearchBasic : SearchRecordBasic {

        private SearchStringField codeField;

        private SearchDateField dateSentField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchLongField idField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField promotionField;

        private SearchMultiSelectField recipientField;

        private SearchLongField useCountField;

        private SearchBooleanField usedField;

        /// <remarks/>
        public SearchStringField code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public SearchDateField dateSent {
            get {
                return this.dateSentField;
            }
            set {
                this.dateSentField = value;
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
        public SearchLongField id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        public SearchMultiSelectField promotion {
            get {
                return this.promotionField;
            }
            set {
                this.promotionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField recipient {
            get {
                return this.recipientField;
            }
            set {
                this.recipientField = value;
            }
        }

        /// <remarks/>
        public SearchLongField useCount {
            get {
                return this.useCountField;
            }
            set {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField used {
            get {
                return this.usedField;
            }
            set {
                this.usedField = value;
            }
        }
    }
}