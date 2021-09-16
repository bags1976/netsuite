namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class GiftCertificateSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] amountRemainingField;

        private SearchColumnDoubleField[] amtAvailBilledField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnStringField[] emailField;

        private SearchColumnDateField[] expirationDateField;

        private SearchColumnBooleanField[] gcActiveField;

        private SearchColumnStringField[] giftCertCodeField;

        private SearchColumnStringField[] incomeAcctField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnStringField[] liabilityAcctField;

        private SearchColumnStringField[] messageField;

        private SearchColumnStringField[] nameField;

        private SearchColumnDoubleField[] originalAmountField;

        private SearchColumnDateField[] purchaseDateField;

        private SearchColumnStringField[] senderField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amountRemaining")]
        public SearchColumnDoubleField[] amountRemaining {
            get {
                return this.amountRemainingField;
            }
            set {
                this.amountRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amtAvailBilled")]
        public SearchColumnDoubleField[] amtAvailBilled {
            get {
                return this.amtAvailBilledField;
            }
            set {
                this.amtAvailBilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createdDate")]
        public SearchColumnDateField[] createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email")]
        public SearchColumnStringField[] email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expirationDate")]
        public SearchColumnDateField[] expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcActive")]
        public SearchColumnBooleanField[] gcActive {
            get {
                return this.gcActiveField;
            }
            set {
                this.gcActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCertCode")]
        public SearchColumnStringField[] giftCertCode {
            get {
                return this.giftCertCodeField;
            }
            set {
                this.giftCertCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("incomeAcct")]
        public SearchColumnStringField[] incomeAcct {
            get {
                return this.incomeAcctField;
            }
            set {
                this.incomeAcctField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnSelectField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("liabilityAcct")]
        public SearchColumnStringField[] liabilityAcct {
            get {
                return this.liabilityAcctField;
            }
            set {
                this.liabilityAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public SearchColumnStringField[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("originalAmount")]
        public SearchColumnDoubleField[] originalAmount {
            get {
                return this.originalAmountField;
            }
            set {
                this.originalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseDate")]
        public SearchColumnDateField[] purchaseDate {
            get {
                return this.purchaseDateField;
            }
            set {
                this.purchaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sender")]
        public SearchColumnStringField[] sender {
            get {
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}