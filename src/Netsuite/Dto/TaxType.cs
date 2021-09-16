namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class TaxType : Record {

        private string nameField;

        private string descriptionField;

        private bool doesNotAddToTotalField;

        private bool doesNotAddToTotalFieldSpecified;

        private bool postToItemCostField;

        private bool postToItemCostFieldSpecified;

        private bool taxInNetAmountField;

        private bool taxInNetAmountFieldSpecified;

        private bool reverseChargeField;

        private bool reverseChargeFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private TaxTypeNexusAccountsList nexusAccountsListField;

        private TaxTypeNexusesTaxList nexusesTaxListField;

        private Country countryField;

        private bool countryFieldSpecified;

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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public bool doesNotAddToTotal {
            get {
                return this.doesNotAddToTotalField;
            }
            set {
                this.doesNotAddToTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool doesNotAddToTotalSpecified {
            get {
                return this.doesNotAddToTotalFieldSpecified;
            }
            set {
                this.doesNotAddToTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool postToItemCost {
            get {
                return this.postToItemCostField;
            }
            set {
                this.postToItemCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postToItemCostSpecified {
            get {
                return this.postToItemCostFieldSpecified;
            }
            set {
                this.postToItemCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool taxInNetAmount {
            get {
                return this.taxInNetAmountField;
            }
            set {
                this.taxInNetAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxInNetAmountSpecified {
            get {
                return this.taxInNetAmountFieldSpecified;
            }
            set {
                this.taxInNetAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool reverseCharge {
            get {
                return this.reverseChargeField;
            }
            set {
                this.reverseChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reverseChargeSpecified {
            get {
                return this.reverseChargeFieldSpecified;
            }
            set {
                this.reverseChargeFieldSpecified = value;
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
        public TaxTypeNexusAccountsList nexusAccountsList {
            get {
                return this.nexusAccountsListField;
            }
            set {
                this.nexusAccountsListField = value;
            }
        }

        /// <remarks/>
        public TaxTypeNexusesTaxList nexusesTaxList {
            get {
                return this.nexusesTaxListField;
            }
            set {
                this.nexusesTaxListField = value;
            }
        }

        /// <remarks/>
        public Country country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countrySpecified {
            get {
                return this.countryFieldSpecified;
            }
            set {
                this.countryFieldSpecified = value;
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