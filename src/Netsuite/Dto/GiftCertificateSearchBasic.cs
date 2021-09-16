namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class GiftCertificateSearchBasic : SearchRecordBasic {

        private SearchDoubleField amountAvailableBilledField;

        private SearchDoubleField amountRemainingField;

        private SearchDateField createdDateField;

        private SearchStringField emailField;

        private SearchDateField expirationDateField;

        private SearchStringField giftCertCodeField;

        private SearchMultiSelectField incomeAccountField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isActiveField;

        private SearchMultiSelectField itemField;

        private SearchMultiSelectField liabilityAccountField;

        private SearchStringField messageField;

        private SearchStringField nameField;

        private SearchDoubleField originalAmountField;

        private SearchDateField purchaseDateField;

        private SearchStringField senderField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchDoubleField amountAvailableBilled {
            get {
                return this.amountAvailableBilledField;
            }
            set {
                this.amountAvailableBilledField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField amountRemaining {
            get {
                return this.amountRemainingField;
            }
            set {
                this.amountRemainingField = value;
            }
        }

        /// <remarks/>
        public SearchDateField createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public SearchDateField expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField giftCertCode {
            get {
                return this.giftCertCodeField;
            }
            set {
                this.giftCertCodeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField incomeAccount {
            get {
                return this.incomeAccountField;
            }
            set {
                this.incomeAccountField = value;
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
        public SearchBooleanField isActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField liabilityAccount {
            get {
                return this.liabilityAccountField;
            }
            set {
                this.liabilityAccountField = value;
            }
        }

        /// <remarks/>
        public SearchStringField message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
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

        /// <remarks/>
        public SearchDoubleField originalAmount {
            get {
                return this.originalAmountField;
            }
            set {
                this.originalAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDateField purchaseDate {
            get {
                return this.purchaseDateField;
            }
            set {
                this.purchaseDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField sender {
            get {
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}