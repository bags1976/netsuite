namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class NexusSearchBasic : SearchRecordBasic {

        private SearchEnumMultiSelectField countryField;

        private SearchStringField descriptionField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchMultiSelectField parentNexusField;

        private SearchMultiSelectField stateField;

        private SearchMultiSelectField taxAgencyField;

        private SearchBooleanField taxDateFromFulfillmentField;

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
        public SearchMultiSelectField parentNexus {
            get {
                return this.parentNexusField;
            }
            set {
                this.parentNexusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField taxAgency {
            get {
                return this.taxAgencyField;
            }
            set {
                this.taxAgencyField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField taxDateFromFulfillment {
            get {
                return this.taxDateFromFulfillmentField;
            }
            set {
                this.taxDateFromFulfillmentField = value;
            }
        }
    }
}