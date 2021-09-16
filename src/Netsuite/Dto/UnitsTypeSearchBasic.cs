namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class UnitsTypeSearchBasic : SearchRecordBasic {

        private SearchStringField abbreviationField;

        private SearchBooleanField baseUnitField;

        private SearchStringField conversionRateField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInActiveField;

        private SearchStringField nameField;

        private SearchStringField pluralAbbreviationField;

        private SearchStringField pluralNameField;

        private SearchStringField unitNameField;

        /// <remarks/>
        public SearchStringField abbreviation {
            get {
                return this.abbreviationField;
            }
            set {
                this.abbreviationField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField baseUnit {
            get {
                return this.baseUnitField;
            }
            set {
                this.baseUnitField = value;
            }
        }

        /// <remarks/>
        public SearchStringField conversionRate {
            get {
                return this.conversionRateField;
            }
            set {
                this.conversionRateField = value;
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
        public SearchBooleanField isInActive {
            get {
                return this.isInActiveField;
            }
            set {
                this.isInActiveField = value;
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
        public SearchStringField pluralAbbreviation {
            get {
                return this.pluralAbbreviationField;
            }
            set {
                this.pluralAbbreviationField = value;
            }
        }

        /// <remarks/>
        public SearchStringField pluralName {
            get {
                return this.pluralNameField;
            }
            set {
                this.pluralNameField = value;
            }
        }

        /// <remarks/>
        public SearchStringField unitName {
            get {
                return this.unitNameField;
            }
            set {
                this.unitNameField = value;
            }
        }
    }
}