namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TaxTypeSearchBasic : SearchRecordBasic {

        private SearchEnumMultiSelectField countryField;

        private SearchStringField descriptionField;

        private SearchBooleanField doesNotAddToTotalField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchStringField nameField;

        private SearchMultiSelectField nexusField;

        private SearchMultiSelectField payablesAccountField;

        private SearchBooleanField postToItemCostField;

        private SearchMultiSelectField receivablesAccountField;

        private SearchBooleanField reverseChargeField;

        private SearchBooleanField taxInNetAmountField;

        /// <remarks/>
        public SearchEnumMultiSelectField country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField doesNotAddToTotal {
            get {
                return this.doesNotAddToTotalField;
            }
            set {
                this.doesNotAddToTotalField = value;
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
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField payablesAccount {
            get {
                return this.payablesAccountField;
            }
            set {
                this.payablesAccountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField postToItemCost {
            get {
                return this.postToItemCostField;
            }
            set {
                this.postToItemCostField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField receivablesAccount {
            get {
                return this.receivablesAccountField;
            }
            set {
                this.receivablesAccountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField reverseCharge {
            get {
                return this.reverseChargeField;
            }
            set {
                this.reverseChargeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField taxInNetAmount {
            get {
                return this.taxInNetAmountField;
            }
            set {
                this.taxInNetAmountField = value;
            }
        }
    }
}