namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class PaymentMethod : Record {

        private string nameField;

        private bool creditCardField;

        private bool creditCardFieldSpecified;

        private bool undepFundsField;

        private bool undepFundsFieldSpecified;

        private RecordRef accountField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private PaymentMethodVisualsList visualsListField;

        private bool isDebitCardField;

        private bool isDebitCardFieldSpecified;

        private RecordRef[] merchantAccountsListField;

        private string payPalEmailAddressField;

        private string expressCheckoutArrangementField;

        private bool useExpressCheckoutField;

        private bool useExpressCheckoutFieldSpecified;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public bool creditCard {
            get {
                return this.creditCardField;
            }
            set {
                this.creditCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditCardSpecified {
            get {
                return this.creditCardFieldSpecified;
            }
            set {
                this.creditCardFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool undepFunds {
            get {
                return this.undepFundsField;
            }
            set {
                this.undepFundsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool undepFundsSpecified {
            get {
                return this.undepFundsFieldSpecified;
            }
            set {
                this.undepFundsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
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
        public bool isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOnlineSpecified {
            get {
                return this.isOnlineFieldSpecified;
            }
            set {
                this.isOnlineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PaymentMethodVisualsList visualsList {
            get {
                return this.visualsListField;
            }
            set {
                this.visualsListField = value;
            }
        }

        /// <remarks/>
        public bool isDebitCard {
            get {
                return this.isDebitCardField;
            }
            set {
                this.isDebitCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDebitCardSpecified {
            get {
                return this.isDebitCardFieldSpecified;
            }
            set {
                this.isDebitCardFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] merchantAccountsList {
            get {
                return this.merchantAccountsListField;
            }
            set {
                this.merchantAccountsListField = value;
            }
        }

        /// <remarks/>
        public string payPalEmailAddress {
            get {
                return this.payPalEmailAddressField;
            }
            set {
                this.payPalEmailAddressField = value;
            }
        }

        /// <remarks/>
        public string expressCheckoutArrangement {
            get {
                return this.expressCheckoutArrangementField;
            }
            set {
                this.expressCheckoutArrangementField = value;
            }
        }

        /// <remarks/>
        public bool useExpressCheckout {
            get {
                return this.useExpressCheckoutField;
            }
            set {
                this.useExpressCheckoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useExpressCheckoutSpecified {
            get {
                return this.useExpressCheckoutFieldSpecified;
            }
            set {
                this.useExpressCheckoutFieldSpecified = value;
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