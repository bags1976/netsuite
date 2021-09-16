namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TaxTypeSearchRowBasic : SearchRowBasic {

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnStringField[] descriptionField;

        private SearchColumnBooleanField[] doesNotAddToTotalField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnStringField[] nameField;

        private SearchColumnSelectField[] nexusField;

        private SearchColumnSelectField[] payablesAccountField;

        private SearchColumnBooleanField[] postToItemCostField;

        private SearchColumnSelectField[] receivablesAccountField;

        private SearchColumnBooleanField[] reverseChargeField;

        private SearchColumnBooleanField[] taxInNetAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("country")]
        public SearchColumnEnumSelectField[] country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public SearchColumnStringField[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("doesNotAddToTotal")]
        public SearchColumnBooleanField[] doesNotAddToTotal {
            get {
                return this.doesNotAddToTotalField;
            }
            set {
                this.doesNotAddToTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
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
        public SearchColumnBooleanField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("nexus")]
        public SearchColumnSelectField[] nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payablesAccount")]
        public SearchColumnSelectField[] payablesAccount {
            get {
                return this.payablesAccountField;
            }
            set {
                this.payablesAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("postToItemCost")]
        public SearchColumnBooleanField[] postToItemCost {
            get {
                return this.postToItemCostField;
            }
            set {
                this.postToItemCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receivablesAccount")]
        public SearchColumnSelectField[] receivablesAccount {
            get {
                return this.receivablesAccountField;
            }
            set {
                this.receivablesAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reverseCharge")]
        public SearchColumnBooleanField[] reverseCharge {
            get {
                return this.reverseChargeField;
            }
            set {
                this.reverseChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxInNetAmount")]
        public SearchColumnBooleanField[] taxInNetAmount {
            get {
                return this.taxInNetAmountField;
            }
            set {
                this.taxInNetAmountField = value;
            }
        }
    }
}